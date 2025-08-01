export interface User {
  id: number;
  firstName: string;
  lastName: string;
  address: string;
  mobile: string;
  email: string;
  department: string;
  designation: string;
  updatedBy: string; // Note: Changed from updatedby to updatedBy
  updated: string;
}
