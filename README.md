# CurrencyApp

1.	Нажмите клавиши WINDOWS + R, чтобы открыть запуска диалоговое окно.
2.	Введите «inetmgr» и выберите ОК
3.	Разверните раздел сайты, нажмите правой кнопкой мыши на имя узла по умолчанию и выберем в появившемся меню пункт Добавить приложение:
 

4.	В появившемся окне введем соответствующие настройки
a.	Псевдоним – currency
b.	Физический путь [Расположение проекта] \publish\api
 
 
5.	Нажать OK

6.	В MS SQL Management Studio выдать права для пользователя IIS APPPOOL\DefaultAppPool :

a.	MS SQL Management Studio  нажмите правой кнопку мыши по имени сервера, далее выберите Свойства 
 
b.	В свойствах сервера выберите раздел Разрешения, в именах для входа выбрать IIS APPPOOL\DefaultAppPool 
c.	В разрешениях предоставить права на:
•	Создание базы данных
•	Соединение с любой базой данных
•	Соединение с любой базой данных
•	Изменение любой базы данных
 
d.	Нажать ОК
WEB API доступно по адресу localhost/currency
Для проверки API пройдите по ссылке http://localhost/currency/api/Currency/Get
 

Запуск WEB приложения

В расположении проекта в директории Currency.React запустить cкрипт  run.bat.
Приложение доступно по адресу http://localhost:3000/