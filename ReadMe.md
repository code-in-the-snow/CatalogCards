I am a book lover, and sometimes I watch The Big Bang Theory. This project was inspired by the beautiful card catalog in Sheldon and Leonard's living room.
If you could get a hold of such (an increasingly difficult to find) piece of furniture, why not use it for its original purpose?

CatalogCards is a C# application to create library catalog-like cards for your books.  

Users input an ISBN (it is assumed you have access to a physical copy of each book), and the project pulls details for the associated edition of the title from the Open Library API to format a catalog card as a Windows form. At this time, the only format is an Author card.

Currently, Open Library is the sole data source for the project.  Please note the following limitations:
	The published date provided is the publication date for the specific edition of the title, NOT the original copyright date.
	Open Library does not include author dates or summaries for the titles.
	Many records are otherwise incomplete- partial publisher information, for example, is common.

An Internet connection is required to access the API.
