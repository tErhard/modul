using System;

public class Task_2
{
	public Task_2()
	{
        document.getElementById("find-number").onclick = () => 
        {
            let number = document.getElementById("car number").value;
            if (number.charAt(0) == 'A' && number.charAt(1) == 'C'
            {
                region = "Закарпатська обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'K'
            {
                region = "АР Крим обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'B'
            {
                region = "Вінницька обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'C'
            {
                region = "Волинська обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'E'
            {
                region = "Дніпропетровська обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'H'
            {
                region = "Донецька обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'M'
            {
                region = "Житомирська обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'P'
            {
                region = "Запорізька обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'T'
            {
                region = "Івано-Франківська обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'I'
            {
                region = "Київська обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'A'
            {
                region = "м. Київ";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'A'
            {
                region = "Кіровоградська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'B'
            {
                region = "Луганська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'C'
            {
                region = "Львівська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'E'
            {
                region = "Миколаївська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'H'
            {
                region = "Одеська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'I'
            {
                region = "Полтавська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'K'
            {
                region = "Рівненська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'M'
            {
                region = "Сумська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'O'
            {
                region = "Тернопільська обл.";
            }
            if (number.charAt(0) == 'A' && number.charAt(1) == 'X'
            {
                region = "Харківська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'T'
            {
                region = "Херсонська обл.";
            }
            if (number.charAt(0) == 'B' && number.charAt(1) == 'X'
            {
                region = "Хмельницька обл.";
            }
            if (number.charAt(0) == 'C' && number.charAt(1) == 'A'
            {
                region = "Черкаська обл.";
            }
            if (number.charAt(0) == 'C' && number.charAt(1) == 'B'
            {
                region = "Чернігівська обл.";
            }
            if (number.charAt(0) == 'C' && number.charAt(1) == 'E'
            {
                region = "Чернівецька обл.";
            }
            if (number.charAt(0) == 'C' && number.charAt(1) == 'H'
            {
                region = "м. Севастополь";
            }
            if (number.charAt(0) == 'I' && number.charAt(1) == 'I'
            {
                region = "Міжрегіональний обл.";
            }
            else
            {
                alert("Правильний номер")
            }


            document.getElementById("region").value = region;
        }

    }
}