
# ToDo List

### In Progress

 - [ ] Make AutoFill find default browser
 - [ ] Make Autofill pull from Edge cookie database (encryption)
 - [ ] Make Autofill pull from Firefox cookie database
 - [ ] Make Listings work
 - [ ] Make downloading work
 - [ ] Make selecting something else unselect All
 - [ ] Make all checkboxes work
		
### Completed

### Ideas

### Notes
 
| Browser | Cookie Path | Cookie Layout | Encryption | RegKeyIdentifier |
| --- | --- | --- | --- |
| Edge | C:\Users\zigby\AppData\Local\Microsoft\Edge\User Data\Default\Network\Cookies | host_key/name/encrypted_value | Yes | MSEdge |
| Chrome  | C:\Users\zigby\AppData\Local\Google\Chrome\User Data\Default\Network\Cookies                    | host_key/name/encrypted_value | Yes | ChromeHTML |
| Firefox | C:\Users\zigby\AppData\Roaming\Mozilla\Firefox\Profiles\tl92esyp.default-release\cookies.sqlite | host/name/value               | No | FirefoxURL-\<random chars\> |

default browser 
`Computer\`