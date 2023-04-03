import { Component, OnInit } from '@angular/core';
import { CommentResponse } from '../../DTOs/comment-aggression/CommentResponse';
import { CommentAggressionService } from '../../services/comment-aggression/comment-aggression.service';

@Component({
  selector: 'app-comment-aggression',
  templateUrl: './comment-aggression.component.html',
  styleUrls: ['./comment-aggression.component.css']
})
export class CommentAggressionComponent implements OnInit {
  commentText: string = 'hello';
  private commentScore: CommentResponse = {} as CommentResponse;

  public isAggressive: boolean = false;
  public probability: number = 0;

  constructor(private commentAggressionService: CommentAggressionService) { }

  ngOnInit(): void {
    
  }

  submitComment() {
    console.log(this.commentText);
    this.commentAggressionService.getCommentScore(this.commentText).subscribe(bi => {
      if (bi?.commentAggression.probability === 0) {
        this.commentAggressionService.getCurrentCommentScore().subscribe(res => {
          this.commentAggressionService.setCurrentCommentScore(res)
        });
      }
      else {
        this.commentScore = bi;
        this.isAggressive = this.commentScore.commentAggression.isAggressive;
        this.probability = this.commentScore.commentAggression.probability;
        console.log(this.commentScore.commentAggression);
      }
    });
  }
}
