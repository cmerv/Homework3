namespace CStephens_Homework3;
class Program
{
    static void Main(string[] args)
    {
// part 1
		Console.WriteLine("------Part 1 begin------");
		Console.WriteLine("Input an integer:");
		int _numInput1 = Convert.ToInt32(Console.ReadLine());
		int _timer1 = 2;
		int _primeResult;

		while (_timer1 < _numInput1) {
		_primeResult = _numInput1%_timer1; // detect modulus as it is good for demonstrating even divisibility
			if (_primeResult==0){
				Console.WriteLine($"{_numInput1} is non-prime. It was divisible by {_timer1}.");
                //Because a number is nonprime if it is divisible by anything, we record and display the first number it is divisible
				break;
			}
			else if (_primeResult!=0 && _timer1==(_numInput1-1)) {
                //if primeResult reports the number is not 0 then we know it finished looping from 2-N so it is prime
				Console.WriteLine($"{_numInput1} is prime.");
				break;
			}
			_timer1++;
			}
		// part 2
		Console.WriteLine("------Part 2 begin------");
		Console.WriteLine ("Assign an integer value to N:");
		int _numInput2 = Convert.ToInt32(Console.ReadLine());
		for (int _height2=0;_height2<_numInput2;_height2++){
            //controls box height
			for (int _length2=0;_length2<_numInput2;_length2++){
                //controls box length
			Console.Write("#");
			}
		 Console.WriteLine("");
		}
		// part 3
		Console.WriteLine("------Part 3 begin------");
		Console.WriteLine ("Assign an integer value to N:");
		int _numInput3 = Convert.ToInt32(Console.ReadLine());
		for (int _height3=0;_height3<_numInput3;_height3++){
            // controls the height of the display
			for (int _length3=0;_length3<=_height3;_length3++){
                // controls width. relate length to height to change output depending on which row we are on
			Console.Write("#");
			}
		Console.WriteLine("");
		}
		// part 4
		Console.WriteLine("------Part 4 begin------");
		Console.WriteLine ("Assign an integer value to N:");
		int _numInput4 = Convert.ToInt32(Console.ReadLine());
        int _blank;
		for (int _height4=0;_height4<=_numInput4;_height4++){
			for (_blank=1;_blank<=_numInput4-_height4;_blank++){
                // defines how we calculate the blank space that fills in where no number exists yet
			Console.Write(" ");
			}
			for (int _length4=1;_blank+_length4<=_numInput4+1;_length4++){ 
                //as we are pushing our numbers all the way to the right, we need to keep track of the left-bound blank space which decreases as we count up
			Console.Write($"{_length4}");
			}
		Console.WriteLine("");
		}
	}
}
