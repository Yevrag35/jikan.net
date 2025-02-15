[![Build status](https://dev.azure.com/bartlomiejbuchala-github/jikan.net/_apis/build/status/jikan.net-.NET%20Desktop-CI)](https://dev.azure.com/bartlomiejbuchala-github/jikan.net/_build/latest?definitionId=1) ![build status](https://travis-ci.org/Ervie/jikan.net.svg?branch=master) ![build status](https://img.shields.io/nuget/v/JikanDotNet.svg) [![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT) [![GitHub issues open](https://img.shields.io/github/issues/Ervie/jikan.net.svg?maxAge=2592000)]() 

# jikan.net

Jikan.net is a .NET wrapper for [Jikan](https://jikan.moe) RESTful API for parsing data from [MyAnimeList](https://myanimelist.com). Main objective of the wrapper is to simplify utilization of Jikan API, as strongly typed languages are not-so-easy to use with elastic json (sure we can go use dynamics in .NET, but let's think about performance).

### Main attributes

* Written in .Net Standard 2.0, compatible with .Net Framework (4.6.1 or newer) and .Net Core (2.0 or newer).
* Fully asynchromous request fetching (can be forced to synchromous if needed).
* Can handle both SSL encrypted and non-SSL encrypted requests.
* Light on dependencies (require only Newtonsoft.Json for parsing).
* Usable with Dependency Injection.

# List of features


- Anime
    - Basic information
    - Characters & Staff
    - Episode
    - News
    - Videos/PV/Episodes
    - Pictures
    - Stats
    - Forum Topics
    - More Info
    - Reviews
    - Recommendations
    - User Updates
- Manga
    - Basic information
    - Characters 
    - News
    - Pictures
    - Stats
    - Forum Topics
    - More Info
    - Reviews
    - Recommendations
    - User Updates
- People
    - Basic information
    - Pictures
- Characters
    - Basic information
    - Pictures
- Search (Anime/Manga/Character/Person)
    - Basic query
    - Filters (Advanced Search)
    - Pagination Support
    - No.# of pages
- Seasonal Anime 
    - Season + Year
    - Undefined airing date
- Season Archive
- Anime Scheduling (for current season)
    - Filtering by day of the week.
- Top
    - Anime
    - Manga
    - People
    - Characters
    - Sub Types & Pagination Support
- Genre
    - Anime genres
    - Manga genres
- Producer
- Magazine
- User
    - Profile
    - Friends
    - History
        - Filter by Anime/Manga.
    - Anime list
        - Filter by status (watching, completed, etc.)
        - Advanced filters
        - Pagination support
    - Manga list
        - Filter by status (reading, completed, etc.)
        - Advanced filters
        - Pagination support
- Clubs
    - Profile
    - Member list
        - Pagination support
- Meta
    - API status
# Installation

### Package manager

```
PM> Install-Package JikanDotNet
```

### .NET CLI

```
>dotnet add package JikanDotNet
```

Then restore dependencies:
```
>dotnet restore
```

# Changelog

## 29.09.2019 - Version 1.3.1

- Fixes
    - <b>[General]</b> Removed null check during creation http client in order to avoid multiple `Jikan` objects holding same url.
    - <b>[Search]</b> Fixed incorrect parameters listing in search queries, which leaded to returning null.
        

**[Read More](https://github.com/Ervie/jikan.net/blob/master/Changelog.md)**

# Documentation &  Usage example

See [project wiki](https://github.com/Ervie/jikan.net/wiki#usage-example).
