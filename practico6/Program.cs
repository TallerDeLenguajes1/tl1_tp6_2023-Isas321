// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("Valor de a: "+a);
// Console.WriteLine("Valor de b: "+b);



 
// int num, cifra;
// int invertido=0;
// Console.WriteLine("Ingrese un numero entero positivo: ");
// bool control=int.TryParse(Console.ReadLine(), out num);
// if(control){
//     while(num>=10){
//         cifra = num%10;
//         num = num/10;
//         invertido = invertido*10 + cifra;  
//     }
//         invertido = invertido*10 + num;

//     Console.WriteLine("Invertido: "+invertido);
// } else{
//     Console.WriteLine("No ingreso un numero entero");
// }


int num;
do{
    Console.WriteLine("Operacion que desea realizar");
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Salir");
    bool control=int.TryParse(Console.ReadLine(), out num);
    switch (num)
    {
        case 1:
            if(bool control=int.TryParse(Console.ReadLine(), out num) AND bool control=int.TryParse(Console.ReadLine(), out num))
            resultado = a + b
            Console.ReadKey();
            break;
        case 2:
            Console.ReadKey();
            break;
        case 3:
            Console.ReadKey();
            break;
        case 4:
            Console.ReadKey();
            break;
        default:
            break;        
        default:
    }

}while(num>5);

