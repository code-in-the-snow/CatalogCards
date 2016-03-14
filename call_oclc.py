# 03-05-2016
# call_oclc.py / IronPython 2.7.5

# Script calls the Online Computer Library Center, Inc. (Open Library) API using an ISBN.  Separate functions return formatted datum.

import requests

def isbn_check(selection):
    if len(selection) == 10 or len(selection) == 13:
        return()
    print("Enter the ISBN as 13 digits or 10 digits without spaces or dashes.")

def get_authors(book, selection):
    count = 1
    result = []
    for author in book['ISBN:' + selection]['authors']:
        result.append(author)
    return result


def get_publishers(book, selection):
    count = 1
    result = []
    for pub in book['ISBN:' + selection]['publishers']:
        result.append(pub)
    return result

def s_published_date(book, selection):
    return book['ISBN:' + selection]['publish_date']

def get_title(book, selection):
    return book['ISBN:' + selection]['title']

def get_loc(book, selection):
    if 'classifications' in book['ISBN:' + selection]:
        return book['ISBN:' + selection]['classifications']['lc_classifications'][0]
    else:
        return " "

def main():
    url_base = 'https://openlibrary.org/api/books?bibkeys=ISBN:'
    url_params = '&jscmd=data&format=json'

    selection = raw_input("Enter the ISBN for your book [no dashes]: ")
    isbn_check(selection)

    # url = requests.get(url_base + selection + url_params)
    book = url.json()

    print
    print get_title(book, selection)
    print get_authors(book, selection)
    print get_publishers(book, selection)
    print get_published_date(book, selection)
    print get_loc(book, selection)
    print()


if __name__ == "__main__":
    main()
