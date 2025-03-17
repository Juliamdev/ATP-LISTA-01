// 1. Média ponderada
        double nota1, nota2, media;
        Console.Write("Digite a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a segunda nota: ");
        nota2 = double.Parse(Console.ReadLine() ?? "0");
        media = (nota1 * 2 + nota2 * 3) / 5;
        Console.WriteLine($"Média: {media:F2}");

        // 2. Preço com desconto de 10%
        double preco, precoDesconto;
        Console.Write("Digite o preço do produto: ");
        preco = double.Parse(Console.ReadLine() ?? "0");
        precoDesconto = preco * 0.9;
        Console.WriteLine($"O preço com desconto é: {precoDesconto:F2}");

        // 3. Área do trapézio
        float base1, base2, altura, area;
        Console.Write("Digite a base maior: ");
        base1 = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a base menor: ");
        base2 = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a altura: ");
        altura = float.Parse(Console.ReadLine() ?? "0");
        area = ((base1 + base2) * altura) / 2;
        Console.WriteLine($"A área do trapézio é: {area:F2}");

        // 4. Quantidade de salários mínimos
        float salarioMinimo, salarioFuncionario, qtdSalarios;
        Console.Write("Digite o valor do salário mínimo: ");
        salarioMinimo = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite o valor do seu salário: ");
        salarioFuncionario = float.Parse(Console.ReadLine() ?? "0");
        qtdSalarios = salarioFuncionario / salarioMinimo;
        Console.WriteLine($"O funcionário recebe {qtdSalarios:F2} salários mínimos");

        // 5. Cálculos com esfera
        double raio, comprimento, areaEsfera, volume;
        const double pi = Math.PI;
        Console.Write("Digite o raio da esfera: ");
        raio = double.Parse(Console.ReadLine() ?? "0");
        comprimento = 2 * pi * raio;
        areaEsfera = pi * Math.Pow(raio, 2);
        volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3);
        Console.WriteLine($"Comprimento: {comprimento:F2}");
        Console.WriteLine($"Área: {areaEsfera:F2}");
        Console.WriteLine($"Volume: {volume:F2}");

        // 6. Terceiro ângulo de um triângulo
        int angulo1, angulo2, angulo3;
        Console.Write("Digite o primeiro ângulo: ");
        angulo1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite o segundo ângulo: ");
        angulo2 = int.Parse(Console.ReadLine() ?? "0");
        angulo3 = 180 - (angulo1 + angulo2);
        Console.WriteLine($"O terceiro ângulo é: {angulo3}");

        // 7. Cáuculo das raízes de uma equação de segundo grau

        

double a, b, c, delta, x1, x2;

        // Entrada dos coeficientes
        Console.Write("Digite o coeficiente 'a': ");
        a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o coeficiente 'b': ");
        b = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o coeficiente 'c': ");
        c = double.Parse(Console.ReadLine() ?? "0");

        // Cálculo do delta
        delta = Math.Pow(b, 2) - 4 * a * c;

        // Como foi dito que as raízes sempre serão reais, não verificamos delta < 0
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        // Exibição dos resultados
        Console.WriteLine($"As raízes da equação são: x1 = {x1:F2}, x2 = {x2:F2}");

        // 8. Notas mínimas para pagar um salário
        int salario, n200, n100, n50, n20, n10, n5, n2, n1;
        Console.Write("Informe o valor do salário: ");
        salario = int.Parse(Console.ReadLine() ?? "0");

        n200 = salario / 200;
        n100 = (salario % 200) / 100;
        n50 = (salario % 200 % 100) / 50;
        n20 = (salario % 200 % 100 % 50) / 20;
        n10 = (salario % 200 % 100 % 50 % 20) / 10;
        n5 = (salario % 200 % 100 % 50 % 20 % 10) / 5;
        n2 = (salario % 200 % 100 % 50 % 20 % 10 % 5) / 2;
        n1 = (salario % 200 % 100 % 50 % 20 % 10 % 5 % 2) / 1;

        Console.WriteLine("Notas necessárias:");
        Console.WriteLine($"200 reais: {n200}");
        Console.WriteLine($"100 reais: {n100}");
        Console.WriteLine($"50 reais: {n50}");
        Console.WriteLine($"20 reais: {n20}");
        Console.WriteLine($"10 reais: {n10}");
        Console.WriteLine($"5 reais: {n5}");
        Console.WriteLine($"2 reais: {n2}");
        Console.WriteLine($"1 real: {n1}");

        // 9. Segundos desde o início do dia
        int horas, minutos, segundos, totalSegundos;
        Console.Write("Digite as horas: ");
        horas = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite os minutos: ");
        minutos = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite os segundos: ");
        segundos = int.Parse(Console.ReadLine() ?? "0");
        totalSegundos = (horas * 3600) + (minutos * 60) + segundos;
        Console.WriteLine($"Total de segundos desde o início do dia: {totalSegundos}");

        // 10. Converter segundos em horas, minutos e segundos
        Console.Write("Digite a quantidade de segundos: ");
        int segundosTotais = int.Parse(Console.ReadLine() ?? "0");

        int horasConvertidas = segundosTotais / 3600;
        int minutosConvertidos = (segundosTotais % 3600) / 60;
        int segundosConvertidos = segundosTotais % 60;

        Console.WriteLine($"Tempo correspondente: {horasConvertidas}h {minutosConvertidos}m {segundosConvertidos}s");