import numpy as np
import matplotlib.pyplot as plt
from numpy.polynomial import Polynomial

# Табличні дані
x_data = np.array([-0.5, -0.3, -0.2, 0.1, 0.4, 0.8])
y_data = np.array([2.3, 1.2, 1.05, 0.9, 1.2, 2.1])

# Знайдемо поліном другого порядку за методом найменших квадратів
degree = 2
coefficients = np.polyfit(x_data, y_data, degree)

# Створимо поліном за знайденими коефіцієнтами
polynomial = Polynomial(coefficients)

# Виведемо коефіцієнти полінома
print("Коефіцієнти полінома:", coefficients)

# Побудуємо графік табличних даних
plt.scatter(x_data, y_data, label='Табличні дані')

# Побудуємо графік знайденого полінома
x_range = np.linspace(min(x_data), max(x_data), 100)
y_range = polynomial(x_range)
plt.plot(x_range, y_range, label='Поліном другого порядку')

# Додамо підписи та легенду
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.title('Найменши квадрати: Табличні дані та поліном другого порядку')

# Показати графік
plt.show()