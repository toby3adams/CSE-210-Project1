// CSE 210 Tic-Tac-Toe Assignment - Samuel Adams


char one = '1';
char two = '2';
char three = '3';
char four = '4';
char five = '5';
char six = '6';
char seven = '7';
char eight = '8';
char nine = '9';
char player = 'X';
int turn = 1;
bool xwin = false;
bool owin = false;

Console.WriteLine($"{one} | {two} | {three}\n----------\n{four} | {five} | {six}\n----------\n{seven} | {eight} | {nine}");

static bool CheckIfXWon(char one, char two, char three, char four, char five, char six, char seven, char eight, char nine){

if (one == 'X' && two == 'X' && three == 'X'){
    return true;
}
else if (four == 'X' && five == 'X' && six == 'X'){
    return true;
}
else if (seven == 'X' && eight == 'X' && nine == 'X'){
    return true;
}
else if (seven == 'X' && four == 'X' && one == 'X'){
    return true;
}
else if (eight == 'X' && five == 'X' && two == 'X'){
    return true;
}
else if (nine == 'X' && six == 'X' && three == 'X'){
    return true;
}
else if (one == 'X' && five == 'X' && nine == 'X'){
    return true;
}
else if (seven == 'X' && five == 'X' && three == 'X'){
    return true;
}
else{
    return false;
}


}

static bool CheckIfOWon(char one, char two, char three, char four, char five, char six, char seven, char eight, char nine){

if (one == 'O' && two == 'O' && three == 'O'){
    return true;
}
else if (four == 'O' && five == 'O' && six == 'O'){
    return true;
}
else if (seven == 'O' && eight == 'O' && nine == 'O'){
    return true;
}
else if (seven == 'O' && four == 'O' && one == 'O'){
    return true;
}
else if (eight == 'O' && five == 'O' && two == 'O'){
    return true;
}
else if (nine == 'O' && six == 'O' && three == 'O'){
    return true;
}
else if (one == 'O' && five == 'O' && nine == 'O'){
    return true;
}
else if (seven == 'O' && five == 'O' && three == 'O'){
    return true;
}
else{
    return false;
}
}


while (turn != 10 && xwin == false && owin == false){
Console.Write($"\n{player} player, please enter a number: ");
int choice = int.Parse(Console.ReadLine());

switch (choice) {
case 1:{
    if (one != '1'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        one = player;
    }
    break;
} 
case 2:{
    if (two != '2'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        two = player;
    }
    break;
} 
case 3:{
    if (three != '3'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        three = player;
    }
    break;
}
case 4:{
    if (four != '4'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        four = player;
    }
    break;
}
case 5:{
    if (five != '5'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        five = player;
    }
    break;
}
case 6:{
    if (six != '6'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        six = player;
    }
    break;
}
case 7:{
    if (seven != '7'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        seven = player;
    }
    break;
} 
case 8:{
    if (eight != '8'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        eight = player;
    }
    break;
} 
case 9:{
    if (nine != '9'){
        Console.WriteLine("Sorry, that space has already been taken.");
    }
    else{
        nine = player;
    }
    break;
} 
default:{
    Console.WriteLine("Sorry, it looks like you entered a number that isnt on the grid");
    break;
}
}



xwin = CheckIfXWon(one, two, three, four, five, six, seven, eight, nine);
owin = CheckIfOWon(one, two, three, four, five, six, seven, eight, nine);



turn += 1;
if (turn % 2 == 0){
    player = 'O';
}
else{
    player = 'X';
}

Console.WriteLine($"\n\n{one} | {two} | {three}\n----------\n{four} | {five} | {six}\n----------\n{seven} | {eight} | {nine}");
}



if (owin == true){
    Console.WriteLine("\nCongratulations player O, You won!");
}
else if (xwin == true){
    Console.WriteLine("\nCongratulations player X, You won!");
}
else{
    Console.WriteLine("\nTied game!");
}



