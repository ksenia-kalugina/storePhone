import { Phone } from '../phone/phone';
import { User } from '../account/user';
export class StoreCartItem {
    constructor(
        public id?: number,
        public phone?: Phone,
        public user?: User ) { }
}
