# algorithm finding "special numbers" C#

C# solution for problem of finding "special numbers". Here is definition of a "special number".
Let the sum of the squares of the digits of the positive number n0 be n1.
Let the sum of the squares of the digits of the number n1 be n2 etc. If ni = 1 for some i bigger than 1, we call the initial digit a "special number".

The algorithm is finding "special numbers" and one number after. The reasult is writing on the screen.
Program uses standard input/output. First it's getting number of tests and then check if input value is a "special number".

Unlike the C++ solution ( https://github.com/barbaraTheProgrammer/algorithm-square-numbers-cpp ) this algorithm is checking if the input number was checking yet.
If it turns out, that input number is "special number", then result is immediately and program goes on. Base of "special numbers" is upgradeing while the program is running,
so it's getting faster. I used for that HashSet.
