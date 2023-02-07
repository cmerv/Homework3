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
		_primeResult = _numInput1%_timer1;
			if (_primeResult==0){
				Console.WriteLine($"{_numInput1} is non-prime. It was divisible by {_timer1}.");
				break;
			}
			else if (_primeResult!=0 && _timer1==(_numInput1-1)) {
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
			for (int _length2=0;_length2<_numInput2;_length2++){
			Console.Write("#");
			}
		 Console.WriteLine("");
		}
		// part 3
		Console.WriteLine("------Part 3 begin------");
		Console.WriteLine ("Assign an integer value to N:");
		int _numInput3 = Convert.ToInt32(Console.ReadLine());
		for (int _height3=0;_height3<_numInput3;_height3++){
			for (int _length3=0;_length3<=_height3;_length3++){
			Console.Write("#");
			}
		Console.WriteLine("");
		}
		// part 4
		Console.WriteLine("------Part 4 begin------");
		Console.WriteLine ("Assign an integer value to N:");
		int _numInput4 = Convert.ToInt32(Console.ReadLine());
		for (int _height4=0;_height4<=_numInput4;_height4++){
			for (int _blank=1;_blank<=_numInput4-_height4;_blank++){
			Console.Write(" ");
			}
			for (int _length4=1;_length4<=_height4;_length4++){
			Console.Write($"{_length4-_height4}");
			}
		Console.WriteLine("");
		}
	}
}
