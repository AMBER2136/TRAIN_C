﻿
Console.Clear();
Console.SetCursorPosition(4,10);
Console.WriteLine("+");
int xa = 40,  ya = 1,
    xb = 1,   yb = 15,
    xc = 80,  yc = 15;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa,  y = xb;
int count = 0;
while(count<1000)
{
    int dot = new Random().Next(0,3); //Интервал от 0 до 2.
   
    if(dot == 0)
    { 
        x=(x+xa)/2;
        y=(y+ya)/2;
    }  
    if(dot == 1)
    { 
        x=(x+xb)/2;
        y=(y+yb)/2;
    }  
    if(dot == 2)
    { 
        x=(x+xc)/2;
        y=(y+yc)/2;
    } 
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count+=1;
}
