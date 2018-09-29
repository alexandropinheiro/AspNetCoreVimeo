import { SeoService } from './../../services/seo.service';
import { Component, OnInit } from '@angular/core';
import { SeoModel } from '../../services/seo.service';

@Component({
  selector: 'app-lista-eventos',
  templateUrl: './lista-eventos.component.html',
  styleUrls: ['./lista-eventos.component.css']
})
export class ListaEventosComponent implements OnInit {

  constructor(seoService: SeoService) {
    const seoModel: SeoModel = <SeoModel>{
      title: 'Seja bem vindo',
      description: 'Lista dos próximos eventos técnicos no Brasil',
      robots: 'Index,Follow',
      keyword: 'eventos,workshops,encontros,congressos'
    };

    seoService.setSeoData(seoModel);

  }

  ngOnInit() {
  }

}
