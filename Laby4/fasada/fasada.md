(1)Cel

Fasada jest strukturalnym wzorcem projektowym, który wyposaża bibliotekę, framework lub inny złożony zestaw klas w uproszczony interfejs.
___


(2)Problem

Problem: złożoność systemu i ścisłe powiązania (tight coupling)
W dużych systemach:

-masz wiele klas i obiektów, które współdziałają,

-logika biznesowa musi znać szczegóły implementacji tych klas,

-musisz pamiętać kolejność wywołań metod, zależności między klasami itd.

To prowadzi do:

-chaosu w kodzie,

-trudnego w utrzymaniu kodu,

-większego ryzyka błędów,

-braku przejrzystości dla programisty czy klienta API.
___


(3)Rozwiązanie

-ukrywa wewnętrzną złożoność systemu (czyli tzw. podsystem),

-udostępnia uproszczony interfejs do kluczowej funkcjonalności.


Co dokładnie robi fasada?

-Agreguje różne klasy pomocnicze/usługi.

-Izoluje klienta od szczegółów implementacji.

-Redukuje sprzężenie między klasami.
___



(4)Analogia do prawdziwego życia

![Fasada - analogia](image-1.png)

Gdy dzwonisz do sklepu aby złożyć zamówienie, biuro jest twoją fasadą dla wszystkich usług i oddziałów tego sklepu. Pracownik sklepu, czy automat zgłoszeniowy, stanowią prosty interfejs głosowy do systemu zamawiania, płacenia i różnych usług dostawczych.
___


(5)UML

![Fasada - UML](image-2.png)

