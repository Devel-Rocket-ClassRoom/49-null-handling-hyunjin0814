using System;

// README.md를 읽고 코드를 작성하세요.
{   int number = 0;
    string text = "";
    string nothing = null;

    Console.WriteLine(number);
    Console.WriteLine(text);
    Console.WriteLine(nothing);

    string name = null;
    Console.WriteLine(name == null);

    int? a = null;
    int? b = null;
    int? c = null;
    double? d = null;
    bool? e = null;

    Nullable<int> n = null;
    Nullable<double> doub = null;

    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);

    int? score = null;
    Console.WriteLine($"score.HasValue: {score.HasValue}");
    score = 95;
    Console.WriteLine($"score.HasValue: {score.HasValue}");
    Console.WriteLine($"score.Value: {score.Value}");

    int? empty = null;
    if (empty.HasValue)
    {
        Console.WriteLine(empty.Value);
    }
    else
    {
        Console.WriteLine("값이 없습니다.");
    }

    int? level = null;
    Console.WriteLine($"기본값 사용: {level.GetValueOrDefault()}");
    Console.WriteLine($"커스텀 기본값: {level.GetValueOrDefault(1)}");
    level = 50;
    Console.WriteLine($"값이 있을 때: {level.GetValueOrDefault()}");
}

{
    int number = 42;
    int? nullable = number;
    int back = (int)nullable;
    Console.WriteLine($"nullable: {nullable}");
    Console.WriteLine($"back: {back}");

    string message = null;
    string result = message ?? "기본 메시지";
    Console.WriteLine(result);
    message = "안녕하세요";
    result = message ?? "기본 메시지";
    Console.WriteLine(result);

    string input = null;
    string output;
    if (input == null)
    {
        output = "기본값";
    }
    else
    {
        output = input;
    }
    Console.WriteLine($"if문 결과: {output}");

    output = input ?? "기본값";
    Console.WriteLine($"?? 연산자 결과: {output}");

    int? score = null;
    Console.WriteLine($"점수: {score ?? -1}");

    int? health = null;
    Console.WriteLine($"체력: {health ?? default(int)}");

    string first = null;
    string second = null;
    string third = "세 번째 값";
    Console.WriteLine(first ?? second ?? third);
}