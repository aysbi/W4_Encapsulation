
using W4_Encapsulation;

Araba araba = new Araba("Audi","A5", "kirmizi", 2); //normal degerler yazip hata vermeyecek

araba.Display();

Araba araba2 = new Araba("Renault", "Megane", "", 5); // hem renksiz yazip hata verecek hem de kapi sayisina -1 yazip hata verecek

araba2.Display();