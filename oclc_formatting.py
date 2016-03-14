# 03-02-2016
# oclc_formatting.py
# script calls the Open Library API using an ISBN, formats the response, and
#  prints result to screen.

import requests

def isbn_check(selection):
    if len(selection) == 10 or len(selection) == 13:
        return()
    print("Enter the ISBN as 13 digits or 10 digits without spaces or dashes.")

def show_authors(book, selection):
    count = 1
    for author in book['ISBN:' + selection]['authors']:
        print("Author " + str(count) + ": " + author['name'])

def show_publishers(book, selection):
    count = 1
    for pub in book['ISBN:' + selection]['publishers']:
        print("Publisher " + str(count) + ": " + pub['name'])

def show_published_date(book, selection):
    print("This edition published " + book['ISBN:' + selection]['publish_date'])

def show_title(book, selection):
    print(book['ISBN:' + selection]['title'])

def show_loc(book, selection):
    if 'classifications' in book['ISBN:' + selection]:
        print("Library of Congress number: " + book['ISBN:' + selection]['classifications']['lc_classifications'][0])
    else:
        print("Library of Congress number unavailable.")

def main():
    url_base = 'https://openlibrary.org/api/books?bibkeys=ISBN:'
    url_params = '&jscmd=data&format=json'

    selection = input("Enter the ISBN for your book [no dashes]: ")
    isbn_check(selection)

    url = requests.get(url_base + selection + url_params)
    book = url.json()

    print()
    show_title(book, selection)
    show_authors(book, selection)
    show_publishers(book, selection)
    show_published_date(book, selection)
    show_loc(book, selection)
    print()


if __name__ == "__main__":
    main()
