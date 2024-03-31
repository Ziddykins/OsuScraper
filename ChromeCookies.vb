' https://github.com/tomsaso/chrome_cookies_vb_dotnet/tree/master/Chrome_cookies_stealer

Imports System.IO
Imports System.Data.SQLite
Imports System.Text
Imports System.Environment
Imports Newtonsoft.Json.Linq
Imports Org.BouncyCastle.Crypto
Imports System.Security.Cryptography
Imports Org.BouncyCastle.Crypto.Parameters
Imports Org.BouncyCastle.Crypto.Modes
Imports Org.BouncyCastle.Crypto.Engines

Friend Module Cookies
    Public Function GetCookieJar(domain_host As String, browser_type As BrowserType) As Dictionary(Of String, String)
        Dim CookiesDict As Dictionary(Of String, String) = New Dictionary(Of String, String)
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand

        KillOpenBrowser(browser_type)



        Dim app_local_data As String = ExpandEnvironmentVariables("%LOCALAPPDATA%")
        Dim app_roaming_data As String = ExpandEnvironmentVariables("%APPDATA%")
        Dim SessionCookie As String = "osu_session"
        Dim XSRFCookie As String = "XSRF-TOKEN"
        Dim cookies_file As String = ""
        Dim database_name As String = ""
        Dim enc_key As Byte() = Nothing
        Dim columns() As String = {"name", "encrypted_value", "host_key"}
        Dim data_source As String

        If browser_type = BrowserType.Chrome Or browser_type = BrowserType.MSEdge Then
            enc_key = GetCookieEncryptionKey(browser_type)
        End If

        Select Case browser_type
            Case BrowserType.Chrome
                cookies_file = app_local_data & "\Google\Chrome\User Data\Default\Network\Cookies"
                database_name = "cookies"
            case BrowserType.Firefox
                cookies_file = app_roaming_data & "\Mozilla\Firefox\Profiles\tl92esyp.default-release\cookies.sqlite"
                database_name = "moz_cookies"
                columns = {"name", "value", "host"}
            Case BrowserType.MSEdge
                cookies_file = app_local_data & "\Microsoft\Edge\User Data\Default\Network\Cookies"
                database_name = "cookies"
            Case BrowserType.Other
                cookies_file = "Unsupportedlol"

        End Select
        
        data_source = "Data Source=" & cookies_file & ";"
        conn = New SQLiteConnection(data_source)
        cmd = conn.CreateCommand()
        cmd.CommandText = $"SELECT {columns(0)}, {columns(1)} FROM main.{database_name} WHERE {columns(2)} LIKE " & domain_host
        conn.Open()

        Using reader As SQLiteDataReader = cmd.ExecuteReader()
            Dim max_lines As Integer = reader.FieldCount

            While reader.Read()        
                If frmMain.tspbProgressBar.Value > frmMain.tspbProgressBar.Maximum Then
                    frmMain.tspbProgressBar.Value = max_lines
                End If
                
              
                Dim name = reader.GetString(0)
                
                If name = SessionCookie Or name = XSRFCookie Then
                    Dim t_byte() As Byte
                    Dim Value As String

                    If browser_type = BrowserType.Chrome Or browser_type = BrowserType.MSEdge Then
                        t_byte = CType(reader.GetValue(1), Byte())
                        Value = _decryptWithKey(t_byte, enc_key, 3)
                    Else
                        Value = reader.GetString(1)
                    End If

                    CookiesDict.Add(name, Value)
                End If
            End While
        End Using

        conn.Close()
        Return CookiesDict
    End Function

    Public Function _decryptWithKey(ByVal message As Byte(), ByVal key As Byte(), ByVal nonSecretPayloadLength As Integer) As String
        Const KEY_BIT_SIZE As Integer = 256
        Const MAC_BIT_SIZE As Integer = 128
        Const NONCE_BIT_SIZE As Integer = 96

        If key Is Nothing OrElse key.Length <> KEY_BIT_SIZE / 8 Then
            Throw New ArgumentException(String.Format("Key needs to be {0} bit!", KEY_BIT_SIZE), "key")
        End If

        If message Is Nothing OrElse message.Length = 0 Then
            Throw New ArgumentException("Message required!", "message")
        End If

        Using cipherStream = New MemoryStream(message)
            Using cipherReader = New BinaryReader(cipherStream)
                Dim nonSecretPayload = cipherReader.ReadBytes(nonSecretPayloadLength)
                Dim nonce = cipherReader.ReadBytes(CInt(Convert.ToDouble(NONCE_BIT_SIZE) / 8.0))
                Dim cipher = New GcmBlockCipher(New AesEngine())
                Dim parameters = New AeadParameters(New KeyParameter(key), MAC_BIT_SIZE, nonce)
                cipher.Init(False, parameters)
                Dim cipherText = cipherReader.ReadBytes(message.Length)
                Dim plainText = New Byte(cipher.GetOutputSize(cipherText.Length) - 1) {}

                Try
                    Dim len = cipher.ProcessBytes(cipherText, 0, cipherText.Length, plainText, 0)
                    cipher.DoFinal(plainText, len)
                Catch __unusedInvalidCipherTextException1__ As InvalidCipherTextException
                    Return Nothing
                End Try

                Return Encoding.[Default].GetString(plainText)
            End Using
        End Using
    End Function
    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return Encoding.Unicode.GetBytes(str)
    End Function

    Public Function GetCookieEncryptionKey(browser_type As BrowserType) As Byte()
        Dim appData As String = GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim keyfile As String = ""
        Dim encryption_key As String
        Dim json_localstate As JObject
        Dim encrypted_key As Object
        Dim encoded_key As String
        Dim decoded_key() As Byte


        If browser_type = BrowserType.Chrome Then
            keyfile = appData & "\Google\Chrome\User Data\Local State"
        Else If browser_type = BrowserType.MSEdge Then
            keyfile = appData & "\Microsoft\Edge\User Data\Local State"
        End If


        encryption_key = File.ReadAllText(keyfile)
        json_localstate = JObject.Parse(encryption_key)
        encrypted_key = json_localstate("os_crypt")("encrypted_key")
        encoded_key = encrypted_key.ToString()
        
        decoded_key = ProtectedData.Unprotect(
            Convert.FromBase64String(encoded_key).Skip(5).ToArray(),
            Nothing,
            DataProtectionScope.LocalMachine
        )

        Return decoded_key
    End Function

    Private Sub KillOpenBrowser(ByRef browser_type As BrowserType)
        Dim browser_name As String = ""

        Select Case browser_type
            Case BrowserType.Chrome
                browser_name = "chrome"
            Case BrowserType.Firefox
                browser_name = "firefox"
            Case BrowserType.MSEdge
                browser_name = "msedge"
            Case BrowserType.Other

        End Select

        For Each process As Process In Process.GetProcessesByName(browser_name)
            Dim user_answer As DialogResult = MessageBox.Show(
                "Found an open " & browser_name & " process. Would you like to close it?",
                "Found Open Browser",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If user_answer = DialogResult.Yes Then
                process.Kill()
            End If            
        Next
    End Sub
End Module