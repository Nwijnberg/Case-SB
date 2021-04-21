# Case-SB

Social Brothers is een bedrijf wat voor opdrachtgevers software op maat ontwikkeld. Het bedrijf heeft gevraagd voor een .NET web api die met een SQLite database communiceert. Deze communicatie moet gebeuren via HTTP.

Het project is gemaakt in Visual Studios Code met .NET Core 5.0 in C#. Het wordt hierom ook sterk aangeraden om het project te runnen in dezelfde applicatie, compleet met de extensions die verder in dit verslag te vinden zijn. De code kan worden gevonden in een Github repository. De link naar deze repository kan worden gevonden in de bijlagen.



### Extensions

Om de api correct te kunnen ronden, moeten een aantal extensions worden geïnstalleerd.

| Extensions                              | Link                                                         | Alternatieve Installatie |
| --------------------------------------- | ------------------------------------------------------------ | ------------------------ |
| C#                                      | https://marketplace.visualstudio.com/items?itemName=mtxr.sqltools |                          |
| C# Extentions                           | https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions |                          |
| C# Snippets                             | https://marketplace.visualstudio.com/items?itemName=jorgeserrano.vscode-csharp-snippets |                          |
| Docker                                  | https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-docker |                          |
| Dotnet Core Commands                    | https://marketplace.visualstudio.com/items?itemName=matijarmk.dotnet-core-commands |                          |
| NuGet Gallery                           | https://marketplace.visualstudio.com/items?itemName=patcx.vscode-nuget-gallery |                          |
| SQLite                                  | https://marketplace.visualstudio.com/items?itemName=alexcvzz.vscode-sqlite |                          |
| SQLtools                                | https://marketplace.visualstudio.com/items?itemName=mtxr.sqltools |                          |
| Microsoft EntityFramework Core          | -                                                            | Via NuGet Gallery.       |
| Microsoft EntityFramework Core SQLite   | -                                                            | Via NuGet Gallery.       |
| Microsoft EntityFramework Core SQLtools | -                                                            | Via NuGet Gallery.       |

*Tabel 1.1: Extensions*



### Functionaliteiten

De web api heeft een aantal functies. De functies staan in de onderstaande tabel beschreven.

| Functies                         | URL route                                                    | Beschrijving                                                 |
| -------------------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ |
| GET - GetAllAddressDatas         | GET https://localhost:<port>/api/AddressData                 | Deze methode geeft de complete lijst van adressen.           |
| GET- GetAddressDataByPostcode    | GET https://localhost:<port>/api/AddressData/postcode/{postcode} | Deze methode geeft een (lijst van) adres(sen) gefilterd op postcode. |
| GET- GetAddressDataByStreet      | GET https://localhost:<port>/api/AddressData/street/{postcode} | Deze methode geeft een (lijst van) adres(sen) gefilterd op straat. |
| GET- GetAddressDataByHousenumber | GET https://localhost:<port>/api/AddressData/housenumber/{postcode} | Deze methode geeft een (lijst van) adres(sen) gefilterd op huisnummer. |
| GET- GetAddressDataByCity        | GET https://localhost:<port>/api/AddressData/city/{postcode} | Deze methode geeft een (lijst van) adres(sen) gefilterd op stad. |
| GET- GetAddressDataByCountry     | GET https://localhost:<port>/api/AddressData/country/{postcode} | Deze methode geeft een (lijst van) adres(sen) gefilterd op land. |
| GET- SortAdressDataByPostcode    | GET https://localhost:<port>/api/AddressData/sort/postcode/{AscOrDesc} | Deze methode geeft de complete lijst van adressen gesorteerd op postcode. |
| GET- SortAdressDataByStreet      | GET https://localhost:<port>/api/AddressData/sort/street/{AscOrDesc} | Deze methode geeft de complete lijst van adressen gesorteerd op straat. |
| GET- SortAdressDataByHousenumber | GET https://localhost:<port>/api/AddressData/sort/housenumber/{AscOrDesc} | Deze methode geeft de complete lijst van adressen gesorteerd op huisnummer. |
| GET- SortAdressDataByCity        | GET https://localhost:<port>/api/AddressData/sort/city/{AscOrDesc} | Deze methode geeft de complete lijst van adressen gesorteerd op stad. |
| GET- SortAdressDataByCountry     | GET https://localhost:<port>/api/AddressData/sort/country/{AscOrDesc} | Deze methode geeft de complete lijst van adressen gesorteerd op land. |
| PUT- UpdateAddressData           | PUT https://localhost:<port>/api/AddressData/{postcode}      | Deze methode bewerkt een adres in de database.               |
| POST- CreateAddressData          | POST https://localhost:<port>/api/AddressData/{postcode}     | Deze methode voegt een adres toe aan de database.            |
| DELETE- DeleteAddressData        | DELETE https://localhost:<port>/api/AddressData/{postcode}   | Deze methode verwijdert een adres uit de database.           |

*Tabel 1.2: Functionaliteiten*



### Tests

Het testen van het API wordt gedaan door middel van het programma Postman. Hierin is het mogelijk een request te testen via een URL. Het programma stuurt dan ook een response terug.



#### GET

##### **Filter** adres bij postcode

Request

```http
GET https://localhost:5001/api/AddressData/sort/postcode/Ascend
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    },
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    },
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 442,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 442,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    }
]
```



##### Filter adres bij straat

Request

```http
GET https://localhost:5001/api/AddressData/sort/street/Descend
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    }
]
```



##### Filter adres bij huisnummer

Request

```http
GET https://localhost:5001/api/AddressData/sort/housenumber/Asc
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 442,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 442,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    }
]
```



##### Filter adres bij stad

Request

```http
GET https://localhost:5001/api/AddressData/sort/city/Desc
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    }
]
```



##### Filter adres bij land

Request

```http
GET https://localhost:5001/api/AddressData/sort/country/Ascend
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    }
]
```



##### Sorteer bij postcode

Request

```http
GET https://localhost:5001/api/AddressData/sort/postcode/Descend
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    },
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    }
]
```



##### Sorteer bij straat

Request

```http
GET https://localhost:5001/api/AddressData/sort/street/Asc
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    }
]
```



##### Sorteer bij huisnummer

Request

```http
GET https://localhost:5001/api/AddressData/sort/housenumber/Desc
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    }
]
```



##### Sorteer bij stad

Request

```http
GET https://localhost:5001/api/AddressData/sort/city/Ascend
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    },
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    }
]
```



##### Sorteer bij land

Request

```http
GET https://localhost:5001/api/AddressData/sort/country/Descend
```



Response

```json
Status: 200 OK
Body:
[
    {
        "postcode": "9485WS",
        "street": "Paseo de Recoletos",
        "house_Number": 45,
        "city": "Madrid",
        "country": "Spain"
    },
    {
        "postcode": "5456EE",
        "street": "Hoefblad",
        "house_Number": 11,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5349RO",
        "street": "Glanshof",
        "house_Number": 11,
        "city": "Amsterdam",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "5803HR",
        "street": "Hoefblad",
        "house_Number": 445,
        "city": "Venray",
        "country": "Netherlands"
    },
    {
        "postcode": "9487HR",
        "street": "Hoornsterzwaag",
        "house_Number": 343,
        "city": "Luxemburg",
        "country": "Luxemburg"
    },
    {
        "postcode": "4752KR",
        "street": "Via Garibaldi",
        "house_Number": 521,
        "city": "Rome",
        "country": "Italy"
    },
    {
        "postcode": "8569LD",
        "street": "Kurfürstendamm",
        "house_Number": 432,
        "city": "Berlin",
        "country": "Germany"
    },
    {
        "postcode": "7500WD",
        "street": "Rue Montorgueil",
        "house_Number": 11,
        "city": "Paris",
        "country": "France"
    },
    {
        "postcode": "PO17GZ",
        "street": "Oxford Street",
        "house_Number": 11,
        "city": "London",
        "country": "England"
    },
    {
        "postcode": "9843HW",
        "street": "Grote Zavel",
        "house_Number": 13,
        "city": "Brussle",
        "country": "Belgium"
    }
]
```



#### POST

Request

```http
POST https://localhost:5001/api/AddressData
```

```json
Body:
  {
      "Postcode":"5803HR",
      "Street":"Hoefblad",
      "House_Number":"44",
      "City":"Venray",
      "Country":"Netherlands"
  }
```



Response

```json
Status: 201 Created
  {
      "Postcode":"5803HR",
      "Street":"Hoefblad",
      "House_Number":"44",
      "City":"Venray",
      "Country":"Netherlands"
  }
```



#### PUT

Request

```http
PUT https://localhost:5001/api/AddressData/5803HR
```

```json
Body:
  {
      "Postcode":"5803HR",
      "Street":"Bladhoef",
      "House_Number":"445",
      "City":"Venray",
      "Country":"Netherlands"
  }
```



Response

```http
Status: 204 No Content
```



#### DELETE

Request

```http
DELETE https://localhost:5001/api/AddressData/5803HR
```

```json
Body:
  {
      "Postcode":"5803HR",
      "Street":"Hoefblad",
      "House_Number":"445",
      "City":"Venray",
      "Country":"Netherlands"
  }
```



Response

```http
Status: 200 OK
```



### Hoogtepunten

Tijdens dit project zijn er een aantal vlakken geweest waar ik sterk in ben verbeterd. Ik heb goede ervaring opgedaan met de C# taal en het framework van .NET. Het is me opgevallen dat ik .NET een stuk prettiger ervaar als andere frameworks die ik tot nu toe heb gebruikt, zoals bijvoorbeeld PHPStorm en IntelliJ van Jetbrains.

Verder vind ik dat ik de web api heel gestructureerd heb opgebouwd. De URL routes om de methoden aan te roepen ben ik voornamelijk trots op. Het is een klein detail, maar een waar ik trots op ben. Een specifiek onderdeel hiervan is de manier van sorteren. De lijst kan - afgezien van een van de kolommen binnen de tabel - gesorteerd worden op alfabetische volgorde óf op numerieke volgorde.



### Minpunten

Een van de grootste minpunten van dit project is GitHub geweest. Ik heb in het begin van het project een repository aangemaakt, die ik in het loop van het project ben vergeten te updaten. De afgelopen dagen ben ik weer begonnen met de repository bij te houden. Verder heb ik gister en vandaag wat problemen gehad met de repository, waardoor ik wat aanpassingen moest maken aan mijn code.