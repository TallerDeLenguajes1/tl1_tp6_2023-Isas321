// // See https://aka.ms/new-console-template for more information

//******* Introduccion  ********

// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("Valor de a: "+a);
// Console.WriteLine("Valor de b: "+b);


//************ Ejercicio 1 *************
int num, cifra;
int invertido=0;
Console.WriteLine("Ingrese un numero entero: ");
bool control=int.TryParse(Console.ReadLine(), out num);
if(control){
    if(num>0){
        while(num>=10){
            cifra = num%10;
            num = num/10;
            invertido = invertido*10 + cifra;  
            }
            invertido = invertido*10 + num;

        Console.WriteLine("El numero ingresado invertido es: "+invertido);
    } else{
        Console.WriteLine("El numero ingresado es: " +num);
    }
} else{
    Console.WriteLine("No ingreso un numero entero");
}

}while(num>5);





