import { Injectable } from "@angular/core";
import { Hero } from "./components/myfirst/myfirst.component";
import { Observable} from 'rxjs';
import { HEROES } from "./mock-heroes";
//import { Observable, of } from 'rxjs';

@Injectable()
export class HeroService {
    heroes: Hero[];
    getHeros(): Hero[]{
        return (HEROES);
    }

    //getHero(id: string | null): Observable<Hero>  {
    //    return of(HEROES.find(hero => hero.id.toString() === id));
    //}
}
