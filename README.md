# Cash Control

## Popis projektu

CashControl je desktopová aplikace pro správu osobních financí, která umožňuje uživatelům snadno evidovat a sledovat své příjmy a výdaje. Aplikace nabízí přehledné rozhraní pro zadávání finančních transakcí, filtrování podle různých kritérií a vizualizaci dat pomocí grafů. Díky jednoduchému ovládání je vhodná jak pro běžné uživatele, tak pro ty, kteří chtějí mít detailní přehled o svých financích.

## Hlavní funkce

- **Evidence transakcí** – přidávání, úprava a mazání záznamů o příjmech a výdajích.
- **Kategorie transakcí** – možnost rozdělit transakce do kategorií, které si uživatel může přidávat, ale nelze je upravovat ani mazat.
- **Filtrování** – snadné filtrování transakcí podle kategorie, typu (příjem/výdaj), měsíce a roku.
- **Grafické přehledy** – zobrazení grafů, které ukazují rozložení výdajů a příjmů podle kategorií a časový vývoj finančního zůstatku.
- **Ukládání kategorií** – kategorie jsou uloženy do samostatného TXT souboru, což umožňuje jejich snadnou správu a přidávání nových kategorií i mimo hlavní aplikaci.

## Datové úložiště – SQLite

Aplikace využívá **SQLite databázi** (`transakce.db`) pro ukládání všech finančních transakcí a dalších dat. SQLite je lehká a rychlá relační databáze, která nevyžaduje žádný samostatný server, což usnadňuje instalaci a správu aplikace.

- Všechny transakce jsou uloženy v databázové tabulce, což zajišťuje rychlý přístup a jednoduché dotazování.
- Při spuštění aplikace se data načítají přímo z `transakce.db`, což umožňuje uchovávat data mezi jednotlivými relacemi.
- Struktura databáze je navržena tak, aby byla snadno rozšiřitelná pro případné nové funkce v budoucnu.

## Technologie

- **C#** – hlavní programovací jazyk.
- **Windows Forms** – framework pro tvorbu uživatelského rozhraní.
- **System.Data.SQLite** – knihovna pro práci s SQLite databází.
- **System.Windows.Forms.DataVisualization.Charting** – pro vykreslení grafů.

## Jak aplikaci používat

1. Spusťte aplikaci.
2. Pro zadání nové transakce klikněte na tlačítko „Přidat“ a vyplňte potřebné údaje (částka, kategorie, typ, datum).
3. Pomocí tlačítek můžete transakce upravovat nebo mazat.
4. Pro přehledné zobrazení finančních dat využijte filtrování podle kategorie, typu, měsíce a roku.
5. Grafy vám vizuálně ukážou rozložení financí a časový vývoj zůstatku.
6. Kategorie lze přidávat – jsou uloženy do samostatného TXT souboru.
7. Všechna finanční data se ukládají do SQLite databáze `transakce.db`, která je uložena ve složce aplikace.

## Další informace

- Data jsou bezpečně uložena lokálně, což zajišťuje plnou kontrolu nad osobními informacemi.
- Uživatelské rozhraní je navrženo pro jednoduchost a přehlednost, aby i začátečníci mohli efektivně spravovat své finance.

---

## Autor

Projekt vytvořil Tomáš Mirvald.
