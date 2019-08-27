export class Phone {
    constructor(
        public id?: number,
        public name?: string,
        public shortDescription?: string,
        public longDescription?: string,
        public img?: string,
        public price?: number,
        public isFovorite?: boolean,
        public available?: boolean,
        public categoryID?: number) { }
}
