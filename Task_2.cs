using System;

public class Task_1
{
	public Task_1()
	{
		let n = prompt("Введіть кількість елементів");
		let arr = new Array();
		for (let i = 0; i < n; i++)
		{
			arr.push(Math.round(Math.random() * 100));

		}
		alert(`1 масив: ${ arr}`);
		var arr2 = arr.filter((x, i, arr) => arr[i] > arr[0]);
		alert(`2 масив: ${ arr2}`);
	}
}
