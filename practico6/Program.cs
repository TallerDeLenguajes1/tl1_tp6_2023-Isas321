// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("Valor de a: "+a);
// Console.WriteLine("Valor de b: "+b);

int num, cifra;
int invertido=0;
Console.WriteLine("Ingrese un numero entero positivo: ");
bool control=int.TryParse(Console.ReadLine(), out num);
if(control){
    while(num>=10){
        cifra = num%10;
        num = num/10;
        invertido = invertido*10 + cifra;  
    }
        invertido = invertido*10 + num;

    Console.WriteLine("Invertido: "+invertido);
} else{
    Console.WriteLine("No ingreso un numero entero");
}


