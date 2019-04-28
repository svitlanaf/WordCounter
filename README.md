# _**Word Counter**_

## _Creating a Word Counter using C# and .NET 4/26/2019_

#### _**By Svitlana Filatova**_

## Description

_This application takes a word and a sentence from user and returns how frequently the word appears in the sentence. It should check for full word matches only._

## Word Counter Specifications

_List of specs:_

|                                                                           Behavior                                                                          |                      Sample Input                      | Sample Output                                      |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------:|:------------------------------------------------------:|----------------------------------------------------|
| User's input is none                                                                                                                                        | Word: none Sentence: none                              | "Your word '' appears 0 times in the sentence."    |
| User inputs 1 word and a sentence of 1 word, and they're matching                                                                                           | Word: "cat" Sentence: "cat"                            | "Your word 'cat' appears 1 times in the sentence." |
| User inputs 1 word and a sentence of 1 word, and they're not matching                                                                                       | Word: "cat" Sentence: "sun"                            | "Your word 'cat' appears 0 times in the sentence." |
| User inputs 1 word and a sentence of 1 word (starts with uppercase letter), and they're matching                                                            | Word: "cat" Sentence: "Cat"                            | "Your word 'cat' appears 1 times in the sentence." |
| User inputs 1 word and a sentence of 1 word (all letters are uppercase), and they're matching                                                               | Word: "cat" Sentence: "CAT"                            | "Your word 'CAT' appears 1 times in the sentence." |
| User inputs 1 word, but sentence is none                                                                                                                    | Word: "cat" Sentence: ""                               | "Your word 'cat' appears 0 times in the sentence." |
| User inputs a sentence, but word is none                                                                                                                    | Word: "" Sentence: "cat in the hat"                    | "Your word '' appears 0 times in the sentence."    |
| User inputs 1 word and a sentence of few words, and some of them are matching                                                                               | Word: "cat" Sentence: "cat in the hat"                 | "Your word 'cat' appears 1 times in the sentence." |
| User inputs 1 word and a sentence of few words (some words have uppercase letters), and some of them are matching                                           | Word: "cat" Sentence: "CAT in The hat caT mad cAt"     | "Your word 'cat' appears 3 times in the sentence." |
| User inputs 1 word and a sentence of few words (some words have uppercase letters), and none of them are matching                                           | Word: "cat" Sentence: "hAT in The fat maT mad fAt"     | "Your word 'cat' appears 0 times in the sentence." |
| User inputs 1 word and a sentence of few words (some words have uppercase letters), and some of sentence words starts with the same letters that a word has | Word: "cat" Sentence: "Cat has a hat at the cathedral" | "Your word 'cat' appears 1 times in the sentence." |                                                                                                                                                       |                                                        |                                                    |

## Setup/Installation Requirements

* _To use this application you need to have .NET (ver. 2.2) Framework and Mono tool installed on your computer._
* _Clone this repository on your desktop._
* _Open Terminal (for Mac users) or PowerShell (for Windows users), navigate to WordCounter folder(cd .../Desktop/WordCounterSolution/WordCounter) and run the following command: mcs Program.cs Models/Word.cs && mono Program.exe._


## Known Bugs
_No bugs were found during testing._


## Support and contact details

_If you find any issue regarding this application please contact Svitlana Filatova via email: svitlana.filatova@gmail.com._


## Technologies Used

_C#/.NET_


### License

*This software is licensed under the MIT license*

Copyright (c) 2019 **Svitlana Filatova**
