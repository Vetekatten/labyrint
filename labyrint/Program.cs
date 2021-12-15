using System;
int room;
room=1;


while (room == 1){
Console.WriteLine("Du står it ett rum av sten, det finns en dörr i det. Går du vidare?");
if (Console.ReadLine() == "ja"){
    room = 2;
}
else if (Console.ReadLine() == "nej"){
    room = 99;
}
else if ((Console.ReadLine() != "ja") || (Console.ReadLine() != "nej")) {
    Console.WriteLine("Fel skrivet, skriv ja eller nej");
}
}

while (room == 2){
Console.WriteLine("Du kommer in i ett andra rum gjort av trä, vill du gå vidare?");
if (Console.ReadLine() == "ja"){
    room = 3;
}
else if (Console.ReadLine() == "nej"){
    room = 1;
}
else {
    Console.WriteLine("Fel skrivet, skriv ja eller nej");
}
}

while (room == 3){
Console.WriteLine("Du kommer in i ett tredje rum av metall, vill du gå ut?");
if (Console.ReadLine() == "ja"){
    room = 4;
}
else if (Console.ReadLine() == "nej"){
    room = 2;
}
else {
    Console.WriteLine("Fel skrivet, skriv ja eller nej");
}
}
if (room == 4){
    Console.WriteLine("Du kommer ut ur byggnaden, hejdå");
    Console.ReadLine();
}
while (room == 99){
    Console.WriteLine("Du står still i rummet tills du dör eftersom du inte har något vatten");
    Console.ReadLine();
}