# PartyMate
http://partymate.apphb.com/

## MVC
![PartyMate Class Diagram](https://github.com/kossov/PartyMate/blob/master/ClassDiagram.png "PartyMate Class Diagram")

## Api

### Clubs

- **Get all Clubs**
    
    **PUBLIC**

    GET: api/Clubs/All?page=1&size=10

    BODY:
    ```js
    [
        {
            "Id": 1,
            "ProfilePicUrl": "http://telerikacademy.com/Content/Images/news-img01.png",
            "Name": "TelerikAcademy",
            "Rating": 0,
            "Location": {
                "Latitude": 42.6508509,
                "Longitude": 23.3772423
            }
        }
    ]
    ```
    
- **Get Club details**
    
    **PUBLIC**

    GET: api/Clubs/Details?id=1
    
    BODY:
    ```js
    {
        "ProfilePicUrl": "http://telerikacademy.com/Content/Images/news-img01.png",
        "Name": "TelerikAcademy",
        "Rating": 0,
        "Adress": "бул. \"Александър Малинов\" 31, 1729 София",
        "Phone": "02 809 9897",
        "SiteUrl": "http://telerikacademy.com/",
        "FacebookUrl": "https://www.facebook.com/TelerikAcademy",
        "TwitterUrl": "https://twitter.com/TelerikAcademy",
        "Email": "",
        "Capacity": 5000,
        "Views": 0,
        "Location": {
            "Latitude": 42.6508509,
            "Longitude": 23.3772423
        },
        "photos": []
    }
    ```