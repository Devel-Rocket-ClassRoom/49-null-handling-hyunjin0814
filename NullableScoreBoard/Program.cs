using System;

// README.md를 읽고 아래에 코드를 작성하세요.
int?[] scores = { 3, null, 7, null, 5 };
int validationCount = 0;
int sum = 0;

Console.WriteLine("=== 경기 상태 ===");
for (int i = 0; i < scores.Length; i++)
{
    if (scores[i].HasValue)
    {
        Console.WriteLine($"경기 {i + 1}: {scores[i].Value}점 (진행 완료)");
        validationCount++;
        sum += scores[i].Value;
    }
    else
    {
        Console.WriteLine($"경기 {i + 1}: 미진행");
    }
}

Console.WriteLine("\n=== 전체 점수 (미진행 = -1) ===");
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"경기 {i + 1}: {scores[i].GetValueOrDefault(-1)}");
}

double avg = (double)sum / validationCount;
Console.WriteLine("\n=== 통계 ===");
Console.WriteLine($"진행된 경기 수: {validationCount}");
Console.WriteLine($"총점: {sum}");
Console.WriteLine($"평균: {avg:F1}");