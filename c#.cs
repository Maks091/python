using System;
using System.IO;

public class Program
{
    static public void Main ()
    {
		File.WriteAllText("test.txt","per t = 1 \noutput: t");
		int stroks =File.ReadAllLines("test.txt").Length;
		string tetts = File.ReadAllText("test.txt");
		int schet = 0;
		int start_rec = 0;
		int contune_read = 0;
		int prosto = 0;
		int prosto1 = 0;
		while (schet < stroks) {
			string[] tets = tetts.Split("\n");
			string code_text = tets[schet];
			string[] code = code_text.Split(" ");
			if (code[0]=="output:"){
				try {
					File.ReadAllText(code[1] + ".txt");
				}
				catch {
					schet += stroks;
				}
				Console.WriteLine(code[1]);
			}
			else if (code[0] == "output") {
				//schet += 1;
				Console.WriteLine("Error. no : in output. Line: " + schet);
				schet += stroks;
			}
			if (code[0] == "per") {
				File.WriteAllText(code[1] + ".txt", code[3]);
			}
		}
    }
}
