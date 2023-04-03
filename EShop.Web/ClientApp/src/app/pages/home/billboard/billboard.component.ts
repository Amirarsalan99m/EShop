import { Component, OnInit } from '@angular/core';
import { Billboard } from '../../../DTOs/billboard/Billboard';
import { BillboardService } from '../../../services/billboard/billboard.service';
import { DomainName } from '../../../utilities/pathTools';

declare function homeSlider():any;

@Component({
  selector: 'home-billboard',
  templateUrl: './billboard.component.html',
  styleUrls: ['./billboard.component.scss']
})
export class BillboardComponent implements OnInit {

  public billboardItems: Billboard[] = [];
  public domain: String = DomainName;

  constructor(private billboardService: BillboardService) { }

  ngOnInit(): void {
    this.billboardService.getCurrentBillboardItems().subscribe(bi => {
      if (bi?.length === 0) {
        this.billboardService.GetBillboardItems().subscribe(res => {
          this.billboardService.setCurrentBillboardItems(res.billboardItems)
        });
      }
      else {
        this.billboardItems = bi;
        console.log(this.billboardItems);
        setInterval(() => {
          homeSlider();
        },100)
      }
    });
  }
}
