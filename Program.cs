// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Program{

    private static int addTwo(int v1, int v2)
    {
        return v1+v2;
    }


    // Squre Pattern
    private static void squarePattern(int n){
        for(int i =1; i<= n; i++){
            for(int j =1; j<=n; j++){
                Console.Write("*");
            }
            Console.WriteLine();
            
        }
    }


    // Triangle Pattern 
    private static void trianglePattern(int n){
        for(int i =1; i<=n; i++){
            for(int j =1; j<= i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Reverse Triangle Pattern
    private static void reverseTrianglePattern(int n){
        for(int i =1; i<=n; i++){
            for(int j =1; j<=n-i+1; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }


    private static void numberTrianglePattern(int n){
        for(int i=1; i<=n; i++){
            for(int j =1; j<=i; j++){
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }


    private static void halfDiamondPattern(int n){
        for(int i =1; i<=n; i++){
            for(int j =1; j<=i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for(int i =1; i<=n; i++){
            for(int j =1; j<=n-i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static void shadowTrianglePattern(int n){
        for(int i =1; i<=n; i++){
            for(int j =1; j<=n-i; j++){
                Console.Write(" ");
            }

            for(int k =1; k<=i; k++){
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }


    private static void reverseShadowTrianglePattern(int n){
        for(int i=1; i<=n; i++){
            for(int k=1; k<=i-1; k++){
                Console.Write(" ");
            }
            for(int j =1; j<=n-i+1; j++){
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }


    private static void fullTrianglePattern(int n){
        for(int i =1; i<=n; i++){
            for(int k=1; k<=n-i; k++){
                Console.Write(" ");
            }

            for(int j=1; j<=i; j++){
                Console.Write("*");
            }

            for(int l=1; l<=i-1; l++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static void reverseFullTriangle(int n){
        for(int i=1; i<=n; i++){
            for(int j=1; j<=i-1; j++){
                Console.Write(" ");
            }

            for(int k =1; k<=n-i; k++){
                Console.Write("*");
            }

            for(int l =1; l<=n-i+1; l++){
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }

    private static void fullTriangleWithSpacePattern(int n){
        for(int i=1; i<=n; i++){
            for(int j=1; j<=n-i; j++){
                Console.Write(" ");
            }

            for(int k =1; k<=i; k++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    private static void fullReverseTriangleWithSpacePattern(int n){
        for(int i=1; i<=n; i++){
            for(int j=1; j<=i-1; j++){
                Console.Write(" ");
            }

            for(int k=1; k<=n-i+1; k++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }



    static void Main(string[] args){
        // Console.WriteLine("Hello World");
        // int a = 10;
        // int b = 20;
        // int ans = addTwo(10,20);
        // Console.WriteLine(ans);
        int n = Convert.ToInt32(Console.ReadLine());
        squarePattern(n);
        Console.WriteLine();


        trianglePattern(n);
        Console.WriteLine();

        reverseTrianglePattern(n);
        Console.WriteLine();

        numberTrianglePattern(n);
        Console.WriteLine();

        halfDiamondPattern(n);
        Console.WriteLine();

        shadowTrianglePattern(n);
        Console.WriteLine();

        reverseShadowTrianglePattern(n);
        Console.WriteLine();

        fullTrianglePattern(n);
        Console.WriteLine();

        reverseFullTriangle(n);
        Console.WriteLine();

        fullTriangleWithSpacePattern(n);
        Console.WriteLine();

        fullReverseTriangleWithSpacePattern(n);
        Console.WriteLine();

    }
    
}




