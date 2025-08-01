import { Component, OnInit, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { UserService } from '../service/user.service';
import { Subject, Subscription } from 'rxjs';
import { debounceTime, distinctUntilChanged } from 'rxjs/operators';
import {
  ChevronFirst,
  ChevronLast,
  ChevronLeft,
  ChevronRight,
  EllipsisVertical,
  File,
  FileChartColumnIncreasing,
  FileText,
  FileX,
  Filter,
  LucideAngularModule,
} from 'lucide-angular';

@Component({
  selector: 'app-user-table',
  standalone: true,
  imports: [CommonModule, FormsModule, LucideAngularModule],
  templateUrl: './user-table.component.html',
  styleUrl: './user-table.component.css',
})
export class UserTableComponent implements OnInit, OnDestroy {
  // Data properties
  users: any[] = [];
  currentPage = 1;
  pageSize = 10;
  totalPages = 1;
  totalItems = 0;
  searchTerm = '';
  isLoading = false;

  // Search Subject for debouncing
  private searchSubject = new Subject<string>();
  private searchSubscription?: Subscription;

  // Icons
  readonly drafticon = FileText;
  readonly activeicon = FileChartColumnIncreasing;
  readonly inactiveicon = File;
  readonly deleteicon = FileX;
  readonly filter = Filter;
  readonly left = ChevronLeft;
  readonly right = ChevronRight;
  readonly last = ChevronLast;
  readonly first = ChevronFirst;
  readonly dot = EllipsisVertical;

  constructor(private userService: UserService) {
    this.setupSearchSubscription();
  }

  ngOnInit() {
    this.loadUsers();
  }

  ngOnDestroy() {
    this.searchSubscription?.unsubscribe();
  }

  private setupSearchSubscription() {
    this.searchSubscription = this.searchSubject
      .pipe(debounceTime(400), distinctUntilChanged())
      .subscribe((searchTerm) => {
        this.currentPage = 1; // Reset to first page on search
        this.searchTerm = searchTerm;
        this.loadUsers();
      });
  }

  loadUsers() {
    this.isLoading = true;
    this.userService
      .getUsers(this.currentPage, this.pageSize, this.searchTerm)
      .subscribe({
        next: (response) => {
          this.users = response.items;
          this.totalItems = response.total;
          this.totalPages = response.totalPages;
          this.isLoading = false;
        },
        error: (error) => {
          console.error('Error loading users:', error);
          this.isLoading = false;
        },
      });
  }

  // Search handler
  onSearch(term: string) {
    this.searchSubject.next(term);
  }

  // Pagination handlers
  goToPage(page: number) {
    if (page !== this.currentPage && page >= 1 && page <= this.totalPages) {
      this.currentPage = page;
      this.loadUsers();
    }
  }

  getPageNumbers(): number[] {
    const pages: number[] = [];
    const maxVisiblePages = 5;

    if (this.totalPages <= maxVisiblePages) {
      // Show all pages if total pages are less than max visible
      for (let i = 1; i <= this.totalPages; i++) {
        pages.push(i);
      }
    } else {
      // Complex pagination logic for many pages
      let startPage = Math.max(1, this.currentPage - 2);
      let endPage = Math.min(this.totalPages, startPage + maxVisiblePages - 1);

      // Adjust start if we're near the end
      if (endPage - startPage < maxVisiblePages - 1) {
        startPage = Math.max(1, endPage - maxVisiblePages + 1);
      }

      for (let i = startPage; i <= endPage; i++) {
        pages.push(i);
      }
    }

    return pages;
  }

  nextPage() {
    if (this.currentPage < this.totalPages) {
      this.goToPage(this.currentPage + 1);
    }
  }

  previousPage() {
    if (this.currentPage > 1) {
      this.goToPage(this.currentPage - 1);
    }
  }

  firstPage() {
    this.goToPage(1);
  }

  lastPage() {
    this.goToPage(this.totalPages);
  }
}
