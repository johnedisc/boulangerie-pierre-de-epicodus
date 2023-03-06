
# [boulangerie-pierre-de-epicodus](https://github.com/johnedisc/boulangerie-pierre-de-epicodus)

#### by [johnedisc](https://johnedisc.github.io)

#### an excercise in making simple command line applications with TDD in MSTest

## technologies used

* C#
* .NET 6
* MSTest
* neovim text editor
* github/git

## description

* this is an epicodus project in our first week of using C# and .NET framework. it explores basic file structure, creating distinct classes, namespaces, fields, constructors, and methods.
* to calculate pastry cost, i employed simple algebra which allowed for experimentation with data types--a concept new to people like myself coming from a weakly typed language.  
* finally, i have experimented with testing in MSTest. it is a tedious but powerful tool, and i am interested to explore further what type of testing is possible here.

## setup/installation requirements

* open a terminal on your machine
* clone down the [repository from github](https://github.com/johnedisc/boulangerie-pierre-de-epicodus) inside the directory of your choosing
```bash
git clone https://github.com/johnedisc/boulangerie-pierre-de-epicodus
```
* move into the directory with Program.cs
```bash
cd BoulangeriePierreDeEpicodus/Boulangerie/
```
* start application
```bash
dotnet run
```
* to run tests, navigate to the Boulangerie.Tests directory and run tests
```bash
cd BoulangeriePierreDeEpicodus/Boulangerie.Tests/
dotnet test
```

## known Bugs

* when selecting a pastry quantity, if you give it a string 2 times in a row, it will terminate the application

## license

feel free to get in touch at [christopher(dot)johnedis(at)gmail(dot)com](christopher.johnedis@gmail.com)

MIT License

Copyright (c) [2023] [christopher johnedis]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
