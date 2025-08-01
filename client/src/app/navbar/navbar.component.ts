import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {
  Bell,
  ClipboardPlus,
  Combine,
  Home,
  LucideAngularModule,
  Settings,
  Star,
} from 'lucide-angular';

@Component({
  selector: 'app-navbar',
  imports: [CommonModule, LucideAngularModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css',
})
export class NavbarComponent {
  logoPath: string = 'assets/logo.png';
  readonly homeicon = Home;
  readonly combine = Combine;
  readonly clipboard = ClipboardPlus;
  readonly bell = Bell;
  readonly star = Star;
  readonly settings = Settings;
}
