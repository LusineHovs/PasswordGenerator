# PasswordGenerator

In **Generator class** you will find **PasswordGenerator()** method, by using this you can generate random passwords with uppercase/lowercase letters, also numbers.
- **PasswordGenerator()** method uses **RNGCryptoServiceProvider class**.

```C#
 using (var rng = new RNGCryptoServiceProvider())
            {
                var data = new byte[4];
                rng.GetBytes(data);
                var seed = BitConverter.ToInt32(data, 0);
                var rnd = new Random(seed);

                string password = string.Empty;

                for (int i = 0; i < length; i++)
                {
                    if (rnd.Next(1, 4) == 1)
                        password += (char)rnd.Next(48, 57);
                    else if (rnd.Next(1, 4) == 2)
                        password += (char)rnd.Next(65, 90);
                    else
                        password += (char)rnd.Next(97, 122);
                }
                return password;
     ```          


Using **UserProgram class** you can execute the program, simply write the required length of password you want to generate, instead of 10. 

~~~ 
Console.WriteLine(Generator.PasswordGenerator(10));
~~~




