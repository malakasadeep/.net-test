import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {
  GaugeCircle,
  Box,
  ShoppingCart,
  Warehouse,
  Factory,
  LineChart,
  Banknote,
  Package,
  Bell,
  Users,
  BarChart3,
  LucideAngularModule,
} from 'lucide-angular';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [CommonModule, LucideAngularModule],
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css'],
})
export class SidebarComponent {
  menuItems = [
    { icon: GaugeCircle, label: 'Admin' },
    { icon: Box, label: 'Core' },
    { icon: ShoppingCart, label: 'Procurement' },
    { icon: Warehouse, label: 'Inventory' },
    { icon: Factory, label: 'Manufacture' },
    { icon: LineChart, label: 'Sales' },
    { icon: Banknote, label: 'Finance' },
    { icon: Package, label: 'Assets' },
    { icon: Bell, label: 'Services' },
    { icon: Users, label: 'CRM' },
    { icon: BarChart3, label: 'Analytics' },
  ];
}
