import { Palestrante } from './Palestrante';
import { Evento } from './Evento';

export interface RedeSocial {
  Id: number;
  Nome: string;
  URL: string;
  EventoId?: number;
  Evento: Evento[];
  PalestrateId: number;
  Palestrante: Palestrante[];
}
