import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { CommentResponse } from '../../DTOs/comment-aggression/CommentResponse';
import { Comment } from '../../DTOs/comment-aggression/Comment';

@Injectable({
  providedIn: 'root'
})
export class CommentAggressionService {
  private comment: BehaviorSubject<Comment> = new BehaviorSubject<Comment>({ isAggressive: false, probability: 0 } as Comment);

  constructor(private http: HttpClient) { }

  public getCommentScore(commentText: string): Observable<CommentResponse> {
    const params = new HttpParams()
      .set('comment', commentText);

    return this.http.post<CommentResponse>('api/ml/submitcomment', null, { params });
  }

  public getCurrentCommentScore(): Observable<Comment> {
    return this.comment;
  }

  public setCurrentCommentScore(comment: Comment) {
    this.comment.next(comment);
  }
}
