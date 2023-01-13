// CREATE-A-QUIZ by Evan C
Console.Clear();
#nullable disable

double score = 0;
// Welcome line
Console.WriteLine("\nWELCOME TO THE CHESS QUIZ");

// Input



// Question 1
Console.WriteLine("\n1. What is the most IMPORTANT piece in chess?");
string Q1 = Console.ReadLine().ToLower();

if (Q1 == "king" || Q1 == "the king") {
    Console.WriteLine($"Q1 Answer: {Q1}");
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
    Console.WriteLine($"Q2 Answer: {Q1}");
}

// Question 2
Console.WriteLine("\n2. What is the most POWERFUL piece in chess?");
string Q2 = Console.ReadLine().ToLower();

if (Q2 == "queen" || Q2 == "the queen") {
    Console.WriteLine($"Q2 Answer: {Q2}");
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
}

// Question 3
Console.WriteLine("\n3. How many small squares are on a chess board?");
string Q3 = Console.ReadLine().ToLower();

if (Q3 == "64") {
    Console.WriteLine($"Q3 Answer: {Q3}");
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
    Console.WriteLine($"Q2 Answer: {Q3}");
}

// Question 4
Console.WriteLine("\n4. What is the only chess piece that can jump over other pieces?");
string Q4 = Console.ReadLine().ToLower();

if (Q4 == "knight") {
    Console.WriteLine($"Q4 Answer: {Q4}");
    Console.WriteLine("Correct");
    score++;
} else {
    Console.WriteLine("Incorrect");
    Console.WriteLine($"Q2 Answer: {Q4}");
}

// Score Display
double results = ((score / 4) * 100);
Console.WriteLine("\nYOUR RESULTS:");
Console.WriteLine($"{score} / 4 ({results}%)");
Console.WriteLine("Good Job");
