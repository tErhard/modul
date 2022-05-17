/*1. Використовуючи js, HTML та СSS створити:

a. Об’єкт для зберігання даних про фільм (Id, назва, режисер,
продюсер, список акторів, URL-трейлеру, рік випуску, касові збори).

b. На основі об’єкту фільму створити новий об’єкт, який перевизначає
метод toString()

c. Об’єкт для зберігання даних про колекцію фільмів, цей об’єкт
повинен містити конструктор та метод впорядкування фільмів за
спаданням касових зборів.

d. Відобразити впорядковані фільми на сторінці.*/

class Film {
    constructor( id, title, director, producer, list_of_actors, URL_trailer, year_of_release, box_office ) {
        this.id = id;
        this.title = title;
        this.author = author;
        this.producer = producer;
        this.list_of_actors = list_of_actors
        this.url_trailer = url_trailer;
        this.year_of_release = year_of_release;
        this.box_office = box_office;
    }
}

class StringifyFilm extends Film {
    ToString(){
        return `
        id:${this.id},
        title:${this.title},
        author:${this.author},
        producer:${this.producer},
        list_of_actors:${this.list_of_actors},
        url_trailer:${this.url_trailer},
        year_of_release:${this.year_of_release},
        box_office:${this.box_office},
        `;
      }
}

class FilmCollection {
    constructor(films = []) {
        this.films =films;
    }
    addOne(elem) {
        this.films.push(elem);
    }
    getById(someId) {
        return this.films.find((elem) => elem.id == someId);
    }
    sortArray(){
        return this.films.sort((elem1,elem2) => elem1.box_office > elem2.box_office);
    }
    getInfo(someId) {
        return this.getById(someId).ToString();
      }
}

class FilmCollectionHtml extends FilmCollection {
    constructor(items) {
        super(items);
    }

    filmToHTML(elem) {
        return `  
        <div class="Film">
        <h2> ${elem.title} </h2>
        <img src="${elem.url_trailer}" alt="">
        <div class="description">
            <p> Author: ${elem.author}</p>
            <p>	${elem.list_of_actors}</p>
            <p> Year of release ${elem.year_of_release} </p>
            <p> ${elem.box_office} box office </p>
        </div>
    </div>`;
    }
}

let Film1 = new Film(
    1,
    "Brian Helgeland",
    "Legend",
    "https://upload.wikimedia.org/wikipedia/en/a/ad/Legend_2015_poster.jpg",
    "Legend",
    2015,
    42425450
);

let all = new FilmCollection();
all.addOne(Film1);