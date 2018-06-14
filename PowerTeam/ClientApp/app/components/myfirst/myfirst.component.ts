import { Component } from '@angular/core';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';
import { HeroService } from "../../hero.service";

@Component({
    selector: 'myfirst',
    templateUrl: './myfirst.component.html'
})
export class MyFirstComponent implements OnInit
{
    heroes : Hero[];
    selectedHero: Hero;

    constructor(private service: HeroService) { }

    ngOnInit(): void {
        this.heroes = this.service.getHeros();
    }

    onSelect(hero: Hero): void {
        this.selectedHero = hero;
    }
}

export class Hero {
    id: number;
    name: string;
}



