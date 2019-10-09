


# ATM Project. Software engineering course.

### Вибір методологіїї розробки ПЗ
----
1. **Основні положення RAD**
	* Інструментарій має бути націлений на мінімізацію часу розробки.
	* Створення прототипу для уточнення вимог замовника.
	* Циклічність розробки: кожна нова версія продукту ґрунтується на оцінці результату роботи попередньої версії замовником.
	* Мінімізація часу розробки версії, за рахунок перенесення вже готових модулів і додавання функціональності в нову версію.
	* Команда розробників повинна тісно співпрацювати, кожен учасник повинен бути готовий виконувати декілька обов'язків.
	* Управління проектом повинне мінімізувати тривалість циклу розробки.
	
2. **Обґрунтування вибору RAD**
	
	Оскільки розробка програмного продукту «ПЗ Банкомату» проходить у стислі строки без зовнішнього фінансування, то використовуючи цю методологію вдасться ефективно використати наданий час, застосовуючи готові бібліотеки та алгоритми. Ця методологія ефективна при відсутності чітко визначеної функціональності або при можливих кардинальних змін під час проектування ПЗ, що відповідає поставленому завданні.
	
	Отже, у поставлених умовах: відсутності команди спеціалістів, загального фінансування та стислих термінах методологія RAD є більш ефективною в порівняні з іншими методологіями.
3.	**Перелік недоліків кожної методології та моделі процесу розробки стосовно обраної програми.**

	* Waterflow – водоспадна модель орієнтована на крупні послідовні проекти з сильним фінансуванням, але найбільший недолік стосовно нашого ПЗ є закріпленість функціоналу на протязі усього циклу розробки, що унеможливлює зміни у функціоналі ПЗ у той час, коли в нашому ПЗ є можливість появи необхідних змін на усіх етапах циклу продукту
	* Agail – така модель не ефективна у проектах з вузькими встановленими строками та непостійним або відсутнім фінансуванням.
	* SCRUM – більше інших підходить з альтернативних гнучких методологій розробки програмного продукту, але для ефективного використання SCRUM потрібна велика команда з чітко визначеними ролями, а також виділення великої кількості часу на обговорення та ревізії.
	* Kanban – не дає таку гнучкість у розробці як Agail та SCRUM оскільки ця методологія орієнтована на масове виробництво – це збільшує вплив фінансування та визначеності фунціоналу на етапах циклу проекту.
	
	 **Висновок**: Після аналізу методології розробки програмних продуктів було встановлено що RAD методологія найбільше з усіх відповідає вимогам при розробці нашого ПЗ.
----
### Розробка вимог до програми
----
1.  **Класифікація вимог до ПЗ**
	 * **Рівні вимог:**
	  	* Вимоги користувача (User requirements) - Опис функцій та обмежень системи.
	  	* Системні вимоги (System requirements) – Деталізований опис системних функцій та обмежень. Вони потрібні для укладання контракту між замовником системи та розробником ПЗ.
	 	* Проектна системна специфікація (software design specification) – Узагальнений опис структури програмної системи, яке буде основою для більш детального проектування системи та її реалізації.
	* **Функціональні та не функціональні вимоги:**
	 	* Функціональні вимоги – Перелік сервісів, які повинна виконувати система, та як вони реагує на ті або інші вхідні дані, як вона поводиться в окремих обставинах. 
	 	* Не функціональні вимоги - Описують характеристики системи та її оточенню, але не самої системи. Можуть бути приведені обмеження на дію функцій системи. 
2. **Вимоги предметної галузі:**
	* **Група функціональних вимог:**
	 	* Бізнес вимоги (Business Requirements) – визначають високорівневі цілі організації або клієнта  (замовника ПЗ)
	 	* Вимоги користувача (User Requirements) – описують цілі та завдання користувацької системи, які повинні виконуватися користувачем за допомогою створеної програмної системи. Такі вимоги часто надаються як варіанти користування (Use Cases).
	 	* Функціональні вимоги (Functional Requirements) – визначають функціональність (поведінку) програмної системи, як повинна бути створена розробником задля надання можливості виконання користувачем своїх обов'язків в рамках бізнес-вимог і в контексті призначених для користувача вимог.

	 * **Група не функціональних вимог:**
	 	* Бізнес-правила (Business Rules) – часто визначають розподіл відповідальності у системи, відповідаючи на питання «хто буде здійснювати конкретний варіант сценарію користування», або диктують появу деяких функціональних вимог.
		 * Зовнішні інтерфейси (External Interfaces) - конкретизація аспектів взаємодії з іншими системами, ОС, можливостями моніторингу при експлуатації. 
	 	* Атрибути якості (Quality Attributes) – описують додаткові характеристики продукту у різних «вимірах», важливих для користувачів та розробників. 
		 *  Обмеження (Constraints) – формулювання умов, модифікуючи вимоги або набору вимог, зменшуючи вибір можливих рішень реалізації. Дон них можуть відноситися параметри продуктивності, впливаючи на вибір платформи реалізації ПЗ.
		 * 	Системні вимоги (System Requirements) – Описують високорівненві вимоги до ПЗ, які мають декілька або багато взаємопов’язаних підсистем та зостосунків.
 
3. **Вимоги до ПЗ, що буде вироблятися:**
	 * **Функціональні:**
	  	* Бізнес вимоги:
Програмна системи повинна відповідати цілям замовника (Банкова системи), а саме вирішувати завдання проведення грошових транзакцій у обраному переліку валюти між представниками клієнтів та організації в цілому, так як забезпечення автономної та надійної системи ПЗ для банкоматів призведе до прискоренню проведення грошових операцій конкретної організації.
	  	* Вимоги користувача:
Проведення між грошових транзакцій. Можливість користування ПЗ на зручній для користувача мові. Виведення інформації про користувача та особовий рахунок на екран та у письмовому вигляді. Зняття готівки. Налаштування конфігурації профілю користувача.
	  	* Функціональні вимоги:
Отримання захищеного доступу до даних профілю користувача. Управління пристроєм зберігання та видачі готівки. Читання та запис параметрів користувача. Режим роботи працівника банку для зміни конфігурації ПЗ. Оперування системою захисту даних користувача. Зберігання інформації о проведених користувачем операції. Управління датчиками зовнішнього впливу. Блокування картки після 4-х провалених перевірок пін-коду. Забирання карти після кінця операції, якщо користувач не забрав її за 2 хвилини
	 * **Не функціональні:**

	  	* 	Зовнішні інтерфейси:
Інтерфейс синхронізація с загальною базою даних. Інтерфейс управління приладами зберігання готівки. Ввід та вивід даних оператора. Управління принтером для виводу інформаційного паперового документу. Інтерфейс зчитування карт. 
	  	* Атрибути якості:
Навчання користуванням ПЗ не повинно перевищувати 20 хвилин. Швидкість проведення транзакцій за встановлений час. Швидкість реагування на дії користувача. Швидкість часу оновлення екрану. Середня тривалість появи двох послідовних помилок у системі. Ймовірність виходу системи з ладу. Час відновлення системи після збою. Ймовірність псування даних при зброю системи.
	  	* Обмеження:
Надання пріоритету у надійності в порівнянні з швидкодією. Використання захищеного каналу зв’язку з банком.
4. **Словник технічних термінів:**
	 1. Вимоги користувача (User requirements)
	 2. Системні вимоги (System requirements)
	 3.	Проектна системна специфікація (software design specification)
	 4.	Бізнес вимоги (Business Requirements)
	 5.	Варіанти користування (Use Cases).
	 6.	Функціональні вимоги (Functional Requirements)
	 7.	Бізнес-правила (Business Rules)
	 8. Зовнішні інтерфейси (External Interfaces)
	 9.	Атрибути якості (Quality Attributes)
	 10.	Обмеження (Constraints)
	 11.	Системні вимоги (System Requirements)
 
 
 **Висновк:** Були вивчені та класифіковані вимоги до розробки ПЗ та описані вимоги для розробки конкретного програмного продукту «ПЗ  Банкомата».

----
### Побудова моделі
----
1. **Обґрунтування вибору моделей, які необхідно побудувати для подальшого проектування програмного забезпечення за обраною темою. Пояснення, що очікується в результаті побудови моделі.**

	Для нашої програмної системи потрібно побудувати:

	* Модель потоків даних, оскільки така модель дає можливість акцентувати на перетворені та маніпуляції вхідних даних, та їх зміни під час різних стадій взаємодії з окремими частинами програмної системи.

	* Композиційну модель , оскільки така модель показує склад сутностей продукту, їх зв’язки  та атрибути, що полегшує створення елементів програмного продукту.

	* Модель взаємодій, яка допомагає при написані специфікації та показує взаємозв’язки користувача та системи.
2. **Для кожної з моделей описання вхідних даних, які будуть покладені в основу,  та принципи побудови.**
	* **Модель потоків даних:**
		* Вхідні дані: унікальний ідентифікатор картки користувача. 
		* Принципом побудови є течія вхідних номерів карти в системі задля отримання розширених даних користувача та проведення транзакції\банківських операцій ґрунтуючись на даних користувача та банку.

	 * **Композиційна модель:**
		* Вхідні дані: основний компонент - програма банкомату та його взаємодія з іншими компонентами системи.  
		* Принципом побудови є взаємодії всіх елементів системи та взаємодії банкомату з банком.

	* **Модель взаємодій:**
		* Вхідні дані: Користувач, банкомат, банк.  
		* Принципом побудови буде є взаємодія користувача з банком через банкомат та отримання користувачем ресурсів.
3. **Побудування моделі.**
	1. **Модель потоків даних:**

	![DataFlow1](https://raw.githubusercontent.com/Miramif/ATM/master/Markdown/Pics/DataFlow_1.png "DataFlow chart") 
	У даній моделі можна побачити потік даних для авторизації та команд. Перший потік даних уявляє собою зчитування даних з карти користувача, порівнянням з даними бази даних та, у разі успіху, отримання авторизацією дозволу  на проведення банківських операцій з користувачем. Другим потоком даних є обробка парсером запитів користувача.

	2. **Композиційна модель:**
	
	![Entity1](https://raw.githubusercontent.com/Miramif/ATM/master/Markdown/Pics/Entity_1.png "Entity chart")
	
	Ця модель показує основі елементи банкомату та їх взаємозв’язок. Так стає зрозуміло що саме здійснює управління у ПС банкомату та атрибути цих елементів.
	3. **Модель взаємодії.**
	
	![UseCase1](https://raw.githubusercontent.com/Miramif/ATM/master/Markdown/Pics/UseCase_1.png "UseCase chart")
	Модель показує взаємодію користувача та оператора з банкоматом та банком під час робочої сесії.

 **Висновок:** були обґрунтовані вибори моделей та пояснені їх призначення та було побудовані ці моделі для програмної системи банкомату.

----
### Обґрунтування вибору мови програмування
----
1. **Складання списку сучасних мов програмування, які застосовуються для  розробки програмного забезпечення.**
	Сучасними та найбільш популярними мовами програмування ПЗ є: *JavaScirpt, Java, Python, C#, PHP, C++, C,  Ruby.*
2. **Обрання 3 мов зі списку програмування та складання їх порівняльної характеристики.**
#### C#
|Призначення | Імперативне | Об`єктно-Ор. |**Функційне** |
|:-----------:|:-----------:|:------------:|:------------:|
 Application, RAD, business, client-side, general, server-side, web | + | + | + |
| **Процедурне** | **Загальне** | **Рефлективне** |**Подійн.-Ор.**|
|+|+|+|+|
|**Інше**|**Стандарт**|
|Structured, concurent|2000, ECMA, ISO|
#### Java
|Призначення | Імперативне | Об`єктно-Ор. |**Функційне** |
|:-----------:|:-----------:|:------------:|:------------:|
 Application, business, client-side, general, mobile development, server-side, web| + | + | + |
| **Процедурне** | **Загальне** | **Рефлективне** |**Подійн.-Ор.**|
|+|+|+|+|
|**Інше**|**Стандарт**|
|Concurent|De facto standard via Java Language Specification|

#### C++
|Призначення | Імперативне | Об`єктно-Ор. |**Функційне** |
|:-----------:|:-----------:|:------------:|:------------:|
 Application, system| + | + | + |
| **Процедурне** | **Загальне** | **Рефлективне** |**Подійн.-Ор.**|
|+|+|-|-|
|**Інше**|**Стандарт**|
||1989, ANSI C89, ISO C90, ISO C99, ISO C11, ISO C18|
3. **Обґрунтування вибору мови програмування, яка буде застосовуватися для реалізації програмного забезпечення.**
Мова програмування С# відповідає усім вимогам для розробки відповідного ПЗ банкомату, має підтримка великої кількості бібліотек та влаштованих класів для спрощення розробки ПЗ. Також ця мова була обрано враховуючи знання та практичні навички розробників ПЗ.

**Висновок**: Зі списку сучасних мов розробки ПЗ, була обрана мова програмування для реалізації програмного забезпечення банкомату.

----
### Діаграма класів та мова UML
----
1. **Визначення мові UML**
UML (англ. Unified Modeling Language) — уніфікована мова моделювання, використовується у парадигмі об'єктно-орієнтованого програмування. Є невід'ємною частиною уніфікованого процесу розробки програмного забезпечення. UML є мовою широкого профілю, це відкритий стандарт, що використовує графічні позначення для створення абстрактної моделі системи, яка називається UML-моделлю. UML був створений для визначення, візуалізації, проектування й документування в основному програмних систем. UML не є мовою програмування, але в засобах виконання UML-моделей як інтерпретованого коду можлива кодогенерація.

2. **Навести основні принципи побудування діаграм класів на мові UML**
Діаграми мови UML відображають статичні (декларативні) елементи, такі як: класи, типи даних, їх зміст та відношення. Діаграма класів, також, може містити позначення для пакетів та може містити позначення для вкладених пакетів. Також, діаграма класів може містити позначення деяких елементів поведінки. На цій діаграмі показують класи, інтерфейси, об'єкти й кооперації, а також їхні відносини: композиція, агрегація, наслідування, асоціація, залежність.
3. **Побудувати діаграму класів до програмного забезпечення**
![ClassDiagram1](https://raw.githubusercontent.com/Miramif/ATM/master/Markdown/Pics/ClassDiagram_1.png "Class diagram")
На даній діаграмі видно, що ПЗ буде мати три основні класи: АТМ – клас первинної обробки вхідної інформації, управління верифікацією та методом обробки запитів; Account – клас акаунту користувача, який обробляє інформацію користувача з бази даних; BANK  – клас, який займається обробкою запитів і надсиланням відповідей на рівні банку.

**Виснок:** Були дослідженні UML-діаграми та побудована діаграма класів ПЗ банкомату.
