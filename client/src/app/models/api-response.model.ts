// models/api-response.model.ts
export interface ApiResponse<T> {
  items: T[];
  total: number;
  page: number;
  pageSize: number;
}
