﻿//2 уровень 4 задание 
using System;


struct Sportsman
{
    private string lastName;
    private float[] jumpDifficulties;
    private float[] jumpScores;
    public float totalScore { get; private set; }

    public Sportsman(
        string lastName,
        float[] jumpDifficulties,
        float[] jumpScores
    )
    {
        this.lastName = lastName;
        this.jumpDifficulties = jumpDifficulties;
        this.jumpScores = jumpScores;
        this.totalScore = 0;

        for (int j = 0; j < this.jumpScores.Length - 1; j++)
        {
            for (int k = j + 1; k < this.jumpScores.Length; k++)
            {
                if (this.jumpScores[j] < this.jumpScores[k])
                {
                    float temp = this.jumpScores[j];
                    this.jumpScores[j] = this.jumpScores[k];
                    this.jumpScores[k] = temp;
                }
            }
        }

        for (int j = 1; j < this.jumpScores.Length - 1; j++)
        {
            this.totalScore += this.jumpScores[j];
        }

        this.totalScore *= this.jumpDifficulties[0];
    }

    public override string ToString()
    {
        return string.Format(
            "Спортсмен - {0}: итоговая оценка - {1}",
            this.lastName,
            this.totalScore
        );
    }

    class Program
    {
        static void Main(string[] args)
        {

            Sportsman[] sportsmen = new Sportsman[5];

            sportsmen[0] = new Sportsman(
                "Иванов",
                new float[] { 3.0f, 2.5f, 3.5f, 3.0f },
                new float[] { 5.0f, 5.5f, 6.0f, 4.5f }
            );

            sportsmen[1] = new Sportsman(
                "Петров",
                new float[] { 2.5f, 3.0f, 2.5f, 3.0f },
                new float[] { 6.0f, 5.5f, 6.5f, 5.0f }
            );

            sportsmen[2] = new Sportsman(
                "Сидоров",
                new float[] { 3.5f, 3.0f, 3.0f, 3.5f },
                new float[] { 5.5f, 6.0f, 5.5f, 6.0f }
            );

            sportsmen[3] = new Sportsman(
                "Козлов",
                new float[] { 2.5f, 2.5f, 3.0f, 2.5f },
                new float[] { 5.0f, 5.0f, 5.0f, 5.0f }
            );

            sportsmen[4] = new Sportsman(
                "Смирнов",
                new float[] { 3.0f, 2.5f, 2.5f, 3.5f },
                new float[] { 4.5f, 4.5f, 5.0f, 4.5f }
            );

            for (int i = 0; i < sportsmen.Length - 1; i++)
            {
                for (int j = i + 1; j < sportsmen.Length; j++)
                {
                    if (sportsmen[i].totalScore < sportsmen[j].totalScore)
                    {
                        Sportsman temp = sportsmen[i];
                        sportsmen[i] = sportsmen[j];
                        sportsmen[j] = temp;
                    }
                }
            }

            for (int i = 0; i < sportsmen.Length; i++)
            {
                Console.WriteLine(sportsmen[i]);
            }
        }
    }
}
