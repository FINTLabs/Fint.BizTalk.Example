# FINT.BizTalk.Example

To eksempler p� hvordan koble seg til felleskomponenten. For � endre http header m� man bruke dynamisk port i en orchestration.

Konfigurasjon finnes i SettingsFileGenerator.xml (�pnes i Excel).

## 1. Authentisering med behavior config

Kun bruk av porter, uten orchestration.

1. Trigger (FILE)
2. GetEmployees (WCF.WebHTTP med custom behavior config)
3. SaveResponse (FILE)


## 2. Manuell authentisering med orchestration

1. Trigger (FILE)
2. Authenticate (WCF.WebHTTP) i orchestration Authenticate 
3. GetEmployees (WCF.WebHTTP) i orchestration GetEmployeesFromFint
3. SaveResponse.


## Behavior config for FINT (for WCF.WebHTTP)

`FintMachine.config` m� legges inn som extension p� Adapter i BizTalk Server Administration.



