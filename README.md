## Borics Krisztián
### NoSQL Exam (Chat app with MongoDb) 2024.10.27.

A repo egy C# nyelven megvalósított chat alkalazást tartalmaz. amely egy lokálisan telepített MongoDb adatbázist használ.

<hr>

#### Előkészületek
- A project fordítását Visual Studio 2022-ben lehet elvégezni. A repo nem tartalmaz bináris állományt.
- A project megnyitása után a  NuGet Package managerrel telepíteni kell a Mongodb.Driver és a MongoDb.Bson csomagokat.

<img src=./img/01_nuget.jpg>

- Telepíteni kell a MongoDb-t, amely innen letölthető : https://www.mongodb.com/products/self-managed/community-edition

#### Leírás
A chat egy három gyüjteményből álló adatbázist kezel. 

<img src=./img/02_db.jpg>

- A users a regisztrált felhasználóneveit és SHA512-es jelszóhash-eit tárolja.

<img src=./img/03_users.jpg>

- A rooms a létrehozott szobák neveit
- A messages pegig az üzeneteket és az azok metaadatait tárolja

<img src=./img/04_msg.jpg>

A chat-be való bejelentkezés előtt authentikálni kell, ha nincs még regisztráió akkor a Sign In fülön tudunk regisztálni a felhasználónév és a jelszó megadásával.

<img src=./img/05_signin.jpg>

Regisztráció után be tudunk jelentkezni a Login fülön. A bejelentkezés után a lenti képernyó látható.

<img src=./img/main.jpg>

A chat részen az eddigi üzenetek láthatóak, a rooms részen lehet kiválasztani, hogy melyik szobában akarunk chat-elni, a create new room részben új szoba adható hozzá. Üzenetet az alső szövegmezőbe kell beírni, majd a send gombbal elküldeni, ami tárolja is az üzenetet az adatbázisban. Ha kiválasztunk egy szobát akkor csak az ide tartozó üzenetek jelennek meg, és a kiválasztott szoba lesz az aktuális szoba, azaz ide fognak menni az üzenetek.

#### Példa

<img src=./img/sample.jpg>