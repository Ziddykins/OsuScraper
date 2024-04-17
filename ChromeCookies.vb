' https://github.com/tomsaso/chrome_cookies_vb_dotnet/tree/master/Chrome_cookies_stealer

Imports System.Data.SQLite
Imports System.Environment
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Engines
Imports Org.BouncyCastle.Crypto.Modes
Imports Org.BouncyCastle.Crypto.Parameters

Friend Module Cookies

    Public Function GetCookieJar(domainHost As String, browserType As BrowserType) As Dictionary(Of String, String)
        Dim cookiesDict As Dictionary(Of String, String) = New Dictionary(Of String, String)
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand

        KillOpenBrowser(browserType)

        Dim appLocalData As String = ExpandEnvironmentVariables("%LOCALAPPDATA%")
        Dim appRoamingData As String = ExpandEnvironmentVariables("%APPDATA%")
        Dim sessionCookie As String = "osu_session"
        Dim xsrfCookie As String = "XSRF-TOKEN"
        Dim cookiesFile As String = ""
        Dim databaseName As String = ""
        Dim encKey As Byte() = Nothing
        Dim columns() As String = {"name", "encrypted_value", "host_key"}
        Dim dataSource As String

        If browserType = BrowserType.Chrome Or browserType = BrowserType.MsEdge Then
            encKey = GetCookieEncryptionKey(browserType)
        End If

        Select Case browserType
            Case BrowserType.Chrome
                cookiesFile = appLocalData & "\Google\Chrome\User Data\Default\Network\Cookies"
                databaseName = "cookies"
            Case BrowserType.Firefox
                cookiesFile = appRoamingData & "\Mozilla\Firefox\Profiles\tl92esyp.default-release\cookies.sqlite"
                databaseName = "moz_cookies"
                columns = {"name", "value", "host"}
            Case BrowserType.MsEdge
                cookiesFile = appLocalData & "\Microsoft\Edge\User Data\Default\Network\Cookies"
                databaseName = "cookies"
            Case BrowserType.Other
                cookiesFile = "Unsupportedlol"

        End Select

        dataSource = "Data Source=" & cookiesFile & ";"
        conn = New SQLiteConnection(dataSource)
        cmd = conn.CreateCommand()
        cmd.CommandText = $"SELECT {columns(0)}, {columns(1)} FROM main.{databaseName} WHERE {columns(2)} LIKE " & domainHost
        conn.Open()

        Using reader As SQLiteDataReader = cmd.ExecuteReader()
            Dim maxLines As Integer = reader.FieldCount

            While reader.Read()

                Dim name = reader.GetString(0)

                If name = sessionCookie Or name = xsrfCookie Then
                    Dim tByte() As Byte
                    Dim value As String

                    If browserType = BrowserType.Chrome Or browserType = BrowserType.MsEdge Then
                        tByte = CType(reader.GetValue(1), Byte())
                        value = _decryptWithKey(tByte, encKey, 3)
                    Else
                        value = reader.GetString(1)
                    End If

                    cookiesDict.Add(name, value)
                End If
            End While
        End Using

        conn.Close()
        Return cookiesDict
    End Function

    Public Function _decryptWithKey(ByVal message As Byte(), ByVal key As Byte(), ByVal nonSecretPayloadLength As Integer) As String
        Const keyBitSize As Integer = 256
        Const macBitSize As Integer = 128
        Const nonceBitSize As Integer = 96

        If key Is Nothing OrElse key.Length <> keyBitSize / 8 Then
            Throw New ArgumentException(String.Format("Key needs to be {0} bit!", keyBitSize), "key")
        End If

        If message Is Nothing OrElse message.Length = 0 Then
            Throw New ArgumentException("Message required!", "message")
        End If

        Using cipherStream = New MemoryStream(message)
            Using cipherReader = New BinaryReader(cipherStream)
                Dim nonSecretPayload = cipherReader.ReadBytes(nonSecretPayloadLength)
                Dim nonce = cipherReader.ReadBytes(CInt(Convert.ToDouble(nonceBitSize) / 8.0))
                Dim cipher = New GcmBlockCipher(New AesEngine())
                Dim parameters = New AeadParameters(New KeyParameter(key), macBitSize, nonce)
                cipher.Init(False, parameters)
                Dim cipherText = cipherReader.ReadBytes(message.Length)
                Dim plainText = New Byte(cipher.GetOutputSize(cipherText.Length) - 1) {}

                Try
                    Dim len = cipher.ProcessBytes(cipherText, 0, cipherText.Length, plainText, 0)
                    cipher.DoFinal(plainText, len)
                Catch unusedInvalidCipherTextException1 As InvalidCipherTextException
                    Return Nothing
                End Try

                Return Encoding.[Default].GetString(plainText)
            End Using
        End Using
    End Function

    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return Encoding.Unicode.GetBytes(str)
    End Function

    Public Function GetCookieEncryptionKey(browserType As BrowserType) As Byte()
        Dim appData As String = GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim keyfile As String = ""
        Dim encryptionKey As String
        Dim jsonLocalstate As JObject
        Dim encryptedKey As Object
        Dim encodedKey As String
        Dim decodedKey() As Byte

        If browserType = BrowserType.Chrome Then
            keyfile = appData & "\Google\Chrome\User Data\Local State"
        ElseIf browserType = BrowserType.MsEdge Then
            keyfile = appData & "\Microsoft\Edge\User Data\Local State"
        End If

        encryptionKey = File.ReadAllText(keyfile)
        jsonLocalstate = JObject.Parse(encryptionKey)
        encryptedKey = jsonLocalstate("os_crypt")("encrypted_key")
        encodedKey = encryptedKey.ToString()

        decodedKey = ProtectedData.Unprotect(
            Convert.FromBase64String(encodedKey).Skip(5).ToArray(),
            Nothing,
            DataProtectionScope.LocalMachine
        )

        Return decodedKey
    End Function

End Module