
/////////////
int[,] calorieTable = {
{900, 750, 1020},
{300, 1000,2700},
{500, 700, 2100},
{400, 900, 1780},
{600, 1200,1100},
{575, 1150,1900},
{600, 1020,1700}
};
double averageCalorieSupper; // Average calorie intake for supper
int totalCalorieForSupper = 0; // Total calorie intake for supper
int totalCalorieForADay = 0; // Total calorie intake for a day
//Average calorie for supper is sum of all calorie intake for supper divided by 7
for (int i = 0; i < 7; i++)
{
    totalCalorieForSupper += calorieTable[i, 2];// supper values are at index 2 for each row
}
averageCalorieSupper = totalCalorieForSupper / 7.0;
// Total calories for Wednesday is the sum of all calories for 3rd row
for (int j = 0; j < 3; j++)
{
    totalCalorieForADay += calorieTable[2, j];
}
//Display results
Console.WriteLine("The average calorie intake for supper during the week = {0:F3}", averageCalorieSupper);
Console.WriteLine("The total calorie intake for Wednesday = {0}", totalCalorieForADay);
Console.ReadKey();
// End CalorieCounter Program