import { Component, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';

import { Hero } from "../myfirst/myfirst.component";
import { HeroService } from "../../hero.service";

@Component({
    selector: 'hero-detail',
    templateUrl: './hero-detail.component.html'
})
export class HeroDetailComponent implements OnInit
{
    @Input() hero: Hero;

    constructor(
        private route: ActivatedRoute,
        private heroService: HeroService

    ) {

    }
    ngOnInit() {
        this.getHero();
    }

    getHero(): void {
        let id = this.route.snapshot.paramMap.get('id');

        //this.heroService.getHero(id);
        
    }
}


