# _Word Counter_

#### _A Nancy web app that allows the user to input a search word and a string to be searched and returns the number of times the search word appears._

#### By _**Chris Wingo**_

## Description

_This program will allow the user to enter a word to search for and a sentence to search in. It will then display the number of times that the word appears in the sentence that they entered._

## Specs

| Behavior - Plain English                                                   | Input                                                        | Output                                                             | Description                                                                                                                                                                                      |
|----------------------------------------------------------------------------|--------------------------------------------------------------|--------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| It will recognize when the search word and the search string are identical | Search word:'A' Search string: "A"                           | 'A' appears one time in the sentence: "A"                          | Because an identical relationship of only one character between the search word and search string shows the program can successfully recognize when the search word is in the search string      |
| It will recognize when the search word and the search string do not match  | Search word: "A" Search string: "I"                          | "A" appears zero times in the sentence: "I"                        | Having only one character to compare is the simplest way of showing that the program can recognize the difference between good matches and bad matches                                           |
| It will recognize how many times a word appears in a sentence              | Search word: 'A' Search string: "A A A"                      | 'A' appears three times in the sentence: "A A A"                   | Because repeating only the search word in the search string, shows the program can successfully count the number of occurances                                                                   |
| It will ONLY count full word matches                                       | Search word: "ham" Search string: "I love ham on hamburgers" | "ham" appears one time in the sentence: "I love ham on hamburgers" | Giving the program a search string where the search word appears only twice, once as a partial match and once as a full match, shows that the program recognizes the difference between the two. |

## Setup/Installation Requirements

### Must have current version of .Net and Mono installed
_Copy all files and folders to your desktop or {git clone} the project. Navigate to the folder in your Windows power shell and run {dnx kestrel} to start the web server. Then, in your address bar, navigate to {//localhost:5004} to get to the home page_

## Known Bugs

_No known issues at this time_

## Support and contact details

_Please feel free to contact me with questions, comments, or contributions to improve the program at cmwingo@gmail.com_

## Technologies Used

* Nancy - Web Interface
* Kestrel - Web Server
* Xunit - Testing


### License

*https://creativecommons.org/licenses/by-nc/3.0/us/legalcode*

Copyright (c) 2016 **_Chris Wingo_**
