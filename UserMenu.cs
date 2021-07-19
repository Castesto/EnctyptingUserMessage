using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{

    class UserMenu
    {

		public delegate void OperationDelegate();
		private List<menuPoint> _menuPoints;

		public struct menuPoint
		{
			public readonly string name;
			public readonly OperationDelegate action;

			public menuPoint(string name, OperationDelegate action)
			{
				this.name = name;
				this.action = action;
			}

		}

		public UserMenu()
		{
			_menuPoints =
				new List<menuPoint>
				{
					new menuPoint("Зашифровать сообщение", () => Console.WriteLine("Я работаю")),
				};
		}

		public void PerformOperation(string namePoint)
		{
			menuPoint point = _menuPoints.Find(point => point.name == namePoint);
            if (point.name == null)
                throw new ArgumentException(string.Format("Operation {0} is invalid", point.name), "point");
            point.action();
		}

		public void PerformOperation(int indexPoint)
		{
			const byte offset = 1;
			indexPoint = indexPoint - offset;

			if ((_menuPoints.Count - 1 < indexPoint) || (indexPoint < 0))
				throw new ArgumentException(string.Format("Menu index {0} is invalid", indexPoint), "point");
			_menuPoints[indexPoint].action();
		}

		public void MenuShow()
        {
			Console.WriteLine("Введите название/номер пункта\n");
			for (int i = 0; _menuPoints.Count > i; i++)
            {
				Console.WriteLine("{0}. {1}", i + 1, _menuPoints[i].name);
            }
        }

	}
}
