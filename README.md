# NameSorter
NameSorter is a simple console in C# that sorts a list of names according to condition :
Given a set of names, order that set first by last name, then by any given names the person may have. A name must have at least 1 given name and may have up to 3 given names.


## Build
You must install the .NET SDK(Software Development Kit) in order to build  
https://www.microsoft.com/net/learn/get-started-with-dotnet-tutorial  


Then just run this in your console :
```javascript
dotnet build NameSorter.sln
```
#### Launch the app



## Example Usage

Given a file called unsorted-names-list.txt containing the following list of names;
```javascript
Orson Milka Iddins
Erna Dorey Battelle
Flori Chaunce Franzel
Odetta Sue Kaspar
Roy Ketti Kopfen
Madel Bordie Mapplebeck
Selle Bellison
Leonerd Adda Mitchell Monaghan
Debra Micheli
Hailey Avie Annakin
```
Executing the program in the following way;
Will result the sorted names to screen;
```javascript
cd ./path-to-executable
name-sorter ./unsorted-names-list.txt
Hailey Avie Annakin
Erna Dorey Battelle
Selle Bellison
Flori Chaunce Franzel
Orson Milka Iddins
Odetta Sue Kaspar
Roy Ketti Kopfen
Madel Bordie Mapplebeck
Debra Micheli
Leonerd Adda Mitchell Monaghan
```
and a file will be generated in the working directory called sorted-names-list.txt containing the sorted names.
 
