string[] arrayWithStrings = new[] {"Лена", "Ока", "Енисей", "Обь", "Клязьма"};
Console.WriteLine("Будете ли вы вводить данные (yes/no):");
Console.WriteLine("(Пояснение: введение ответов, отличающихся от предложенных в скобках будет трактоваться - как ответ no)");
string answer = Console.ReadLine();
if(answer == "yes")
{
    Console.WriteLine("Хорошо, пожалуйста введите данные через пробел: ");
    string userInput = Console.ReadLine();
    arrayWithStrings = userInput.Split();    
}
int countOfStrings = 0;
foreach(string i in arrayWithStrings)
{
    if(i.Length <= 3)
    {
        countOfStrings ++;
    }
}
int currentIndex = 0;
string[] finalArray = new string[countOfStrings];
for(int i = 0; i < arrayWithStrings.Length; i++)
{
    if(arrayWithStrings[i].Length <= 3)
    {
        finalArray[currentIndex] = arrayWithStrings[i];
        currentIndex ++;
    }
}
for (int i = 0; i < finalArray.Length; i++)
        {
            Console.Write(finalArray[i]);
            if (i < finalArray.Length - 1) {
                Console.Write(", ");
            }
        }