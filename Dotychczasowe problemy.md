# Platforma-do-promocji-muzyki
1. Po aktualizacji VS do wersji 15.9.2 dodatek Git miał problem z commitowaniem :

Git failed with a fatal error.error: open("Platform/.vs/Platforma/v15/Server/sqlite3/db.lock"): 
Permission deniedfatal: Unable to process path Platforma/.vs/Platforma/v15/Server/sqlite3/db.lock

Należało dodać folder .vs do gitignore.


2. Wyglądy aplikacji pobierane z bootswatch.com nie działają do końca poprawnie(jak w tutorialu). Należy pobierać z bootswatch.com/3
