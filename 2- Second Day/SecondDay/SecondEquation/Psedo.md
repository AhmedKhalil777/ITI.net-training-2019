# In The Name OF ALLAH
---
## Quadratic Equation
 
### Extraction Method
---
 - we need 3 double varuiables to extaract the equation over it.
 - so ,,, I can implement it by an array
 - The Regular expression I can extract by many ways but to get a,b,c .


```
        public static double[] EquationExtraction(string Eq)
        {
            double[] Ext = new double[3];
            try
            {
                Eq = Eq.Replace("+", "e+");
                Eq = Eq.Replace("-", "e-");
                string LHS ="+"+ Eq.ToUpper().Split('=')[0];
                string RHS = Eq.ToUpper().Split('=')[1];
                if (LHS[0] == '+'&& LHS[1]!='E')
                {
                    LHS = "E" + LHS;
                }
                string[] Params = LHS.Split('E');
               
                for (int i = 1; i < 4; i++)
                {
                    Params[i] = (Params[i].Split("X")[0]);
                    if (Params[i] == "-" || Params[i] == "+")
                    {
                        Params[i] += "1";
                    }
                    Ext[i-1 ] = double.Parse((Params[i]));
                }

                Ext[2] -= double.Parse(RHS);
                
            }
            catch (Exception ex)
            {

                Console.WriteLine( ex.Message+
                    "\n Invalid Equation Syntax Plz Write AS Following Expression (+-)ax^2(+-)bx(+-)c = d");
                
            }
            return Ext;

        }
```
---
## Is Valid Method 

 - There are 3 conditions 
  > If Special >0 __The values in The Real Spacial__ of x and y 


  > if spacial = 0 __The Values are equivelant__ .

  > else __Its is Imagine__  so I can reserve :
 ```
          double special, imagine, real;
 ```

 -
---
```
           double special, imagine, real;
            string first, second;
          Console.Write("Enter The Equation : ");
          double[] x = EquationExtraction(Console.ReadLine());
            if (!IsImagine(x))
            {
                special = (Math.Sqrt(Math.Pow(x[1], 2) - 4 * x[0] * x[2]));
                first = ((-1 * x[1] / (2 * x[0])) + (special / (2 * x[0]))).ToString();
                second = ((-1 * x[1] / (2 * x[0])) -(special / (2 * x[0]))).ToString();

            }
            else
            {
                imagine = (Math.Sqrt((Math.Pow(x[1], 2) - 4 * x[0] * x[2]) *-1)) /2*x[0];
                real = (-1 * x[1]) / 2 * x[0];
                first = real.ToString() + " +  " + imagine.ToString() + "i";
                second = real.ToString() +"  -  " + imagine.ToString() + "i";
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
```