// F# Program | a simple console application that reads in the name and age of a person
// a) If age >= 20 then the field is a string which states the person's name and that they are no longer a teenager 
// b) If the age < 20 and greater than 13 then the field is a string that states the persons name and that they are a teenage
// c) If the age is =< than 13 then is states the name and the person is a kid or child.

open System
[<EntryPoint>]
let main argv = 
    Console.WriteLine("Person's name:")
    let name = Console.ReadLine()
    Console.WriteLine("Person's age:")
    let age = Console.ReadLine()
    let age = int age
    let msg = 
        if age >= 20 then "no longer a teenager"
        elif (age < 20 && age > 13) then "teenage"
        else "kid or child" 

    Console.WriteLine("Name: {0} - Age: {1} - {2}", name, age, msg)
    Console.ReadKey()
    0