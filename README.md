# FINT.BizTalk.Example

To eksempler p� hvordan koble seg til felleskomponenten. For � endre http header m� man bruke dynamisk port i en orchestration.

Konfigurasjon finnes i SettingsFileGenerator.xml (�pnes i Excel).

## 1. Uten authentisering mot play-with-fint-milj�

Kun bruk av porter, uten orchestration.

1. Trigger (FILE)
2. GetEmployees (WCF.WebHTTP)
3. SaveResponse (FILE)

## 2. Med authentisering mot beta-milj�

1. Trigger (FILE)
2. Authenticate (WCF.WebHTTP) i orchestration Authenticate 
3. GetEmployees (WCF.WebHTTP) i orchestration GetEmployeesFromFint
3. SaveResponse.